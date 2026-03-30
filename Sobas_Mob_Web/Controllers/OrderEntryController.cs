using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sobas_Mob;
using Sobas_Mob_Web.Models;


namespace Sobas_Mob_Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderEntryController : ControllerBase
    {

        private readonly CommonDB_TestDbContext _Dbcontext;
      

        public OrderEntryController(CommonDB_TestDbContext Dbcontext)
        {
            _Dbcontext = Dbcontext;
            
        }
        [Authorize]
        [HttpGet("GetItemCode")]
        public async Task<IActionResult> GetItemCode()
        {
            var data = await _Dbcontext.PartyMs //Live DB
                .Where(x => x.IsActive == true &&
                    x.PartyTypeUid == Guid.Parse("46B89E78-B97A-44D3-83E9-8661436A50BA") &&
                    x.PartyCode.Length >= 5 &&                 // 🔴 IMPORTANT (see issue 2)
                    x.PartyCode.Substring(2, 3) == "148" //&&
                                                         //x.Gstno != null &&
                    /*x.Gstno.Length == 15*/).OrderBy(x => x.PartyName)
                .Select(x => new PartyDto
                {
                    PartyCode = x.PartyCode,
                    PartyName = x.PartyName

                })
                .ToListAsync();

            return Ok(data);
        }

        [Authorize]
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] SaleOrderMobileDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var today = DateTime.Now;
                // string year = (today.Year % 100).ToString("D2");  commanded for financial Year 

                // Added for Financial year 
                int startYear = today.Month >= 4 ? today.Year : today.Year - 1;
                int endYear = startYear + 1;

                string financialYear = $"{startYear % 100:D2}-{endYear % 100:D2}";

                //string partySegment = dto.PartyCode?.Length >= 5
                //    ? dto.PartyCode.Substring(2, 3)
                //    : "000";
                string partySegment = "148";
                string newOrderNo;

                // 🔥 STEP 1: Check existing inactive order for same party
                var existingOrder = await _Dbcontext.SalesOrderForMobiles //Live DB
                    .Where(x => x.PartyCode == dto.PartyCode
                             && x.PartyName == dto.PartyName
                             && x.IsActive == false)
                    .OrderByDescending(x => x.CreatedDate)
                    .FirstOrDefaultAsync();

                if (existingOrder != null)
                {
                    // ✅ Reuse existing OrderNo
                    newOrderNo = existingOrder.OrderNo;
                }
                else
                {

                   var orderNumbers = await _Dbcontext.SalesOrderForMobiles.Where(x => x.OrderNo != null)  //Live DB
                                          .Select(x => x.OrderNo).ToListAsync();

                    string lastOrderNo = orderNumbers.OrderByDescending(order =>
                    {
                        var lastPart = order.Split('-').Last();
                        return int.TryParse(lastPart, out int num) ? num : 0;
                    })
                                         .FirstOrDefault();

                    int nextRunning = 1;

                    if (!string.IsNullOrEmpty(lastOrderNo))
                    {
                        string runningPart = lastOrderNo.Split('-').Last();

                        if (int.TryParse(runningPart, out int lastRunning))
                        {
                            nextRunning = lastRunning + 1;
                        }
                    }

                    //newOrderNo = $"SC-{partySegment}-{year}-{nextRunning:D5}"; Commanded for changeing financial year
                    newOrderNo = $"SC-{partySegment}-{financialYear}-{nextRunning:D5}";
                }


                // Extract new category
                string newCategory = dto.Remarks?
                    .Split('/')
                    .FirstOrDefault()?
                    .Trim();

                if (!string.IsNullOrWhiteSpace(newCategory))
                {
                    // Get existing remarks for same order
                    var existingRemarks = await _Dbcontext.SalesOrderForMobiles  //Live DB
                        .Where(x =>
                            x.OrderNo == newOrderNo &&
                            x.PartyCode == dto.PartyCode &&
                            x.PartyName == dto.PartyName &&
                            x.IsActive == true &&
                            x.Remarks != null)
                        .Select(x => x.Remarks)
                        .ToListAsync();

                    if (existingRemarks.Any())
                    {
                        // Get the FIRST category already used in order
                        var existingCategory = existingRemarks
                            .Select(r => r.Split('/')[0].Trim())
                            .FirstOrDefault();

                        // If different category → BLOCK
                        if (existingCategory != null &&
                            !existingCategory.Equals(newCategory, StringComparison.OrdinalIgnoreCase))
                        {
                            return BadRequest(
                                $"Order already contains category '{existingCategory}'. Multiple categories are not allowed in the same order."
                            );
                        }
                    }
                }

                // 🔥 Create Order
                var order = new Models.SalesOrderForMobile  //Live DB
                {
                    SalesOrderUid = Guid.NewGuid(),
                    OrderNo = newOrderNo,
                    OrderDate = DateTime.Now,
                    PartyCode = dto.PartyCode,
                    PartyName = dto.PartyName,
                    ItemCode = dto.ItemCode,
                    ItemDescription = dto.ItemDescription,
                    Quantity = dto.Quantity,
                    Remarks = dto.Remarks,
                    Specifications = dto.Remarks ?? "",  // prevent NULL error
                    IsActive = false,                    // important
                    CreatedDate = DateTime.Now,
                    CreatedBy = dto.PartyName,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = dto.PartyName
                };

                await _Dbcontext.SalesOrderForMobiles.AddAsync(order); //Live DB
                await _Dbcontext.SaveChangesAsync(); // Live DB

                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException?.Message ?? ex.Message);
            }

        }
        [Authorize]
        [HttpGet("GetByOrderId/{orderNo}")]
        public async Task<IActionResult> GetByOrderId(string orderNo, [FromQuery] string PartyCode, [FromQuery] string PartyName)
        {
            var items = await _Dbcontext.SalesOrderForMobiles //Live DB
                .AsNoTracking()
                .Where(x => x.OrderNo == orderNo && x.IsActive == false &&
                (!string.IsNullOrEmpty(PartyCode) || x.PartyCode == PartyCode) &&
                (!string.IsNullOrEmpty(PartyName) || x.PartyName == PartyName))
                .Select(x => new SaleOrderMobileDto
                {
                    OrderNo = x.OrderNo,
                    SalesOrderUid = x.SalesOrderUid,
                    ItemCode = x.ItemCode,
                    ItemDescription = x.ItemDescription,
                    Quantity = x.Quantity
                })
                .ToListAsync();

            if (items == null || items.Count == 0)
                return NotFound("Order not found");

            return Ok(items);
        }
        [Authorize]
        [HttpPut("ActivateOrder/{OrderNo}/{UserName}")]
        public async Task<IActionResult> ActivateOrder(string OrderNo, string UserName)
        {
            var orders = await _Dbcontext.SalesOrderForMobiles  //Live DB
                .Where(x => x.OrderNo == OrderNo)
                .ToListAsync();

            if (!orders.Any())
                return NotFound("Order not found");

            foreach (var order in orders)
            {
                order.IsActive = true;
                order.CreatedBy = UserName;
                order.ModifiedBy = UserName;
                order.ModifiedDate = DateTime.Now;
                order.OrderDate = DateTime.Now;
            }

            var res = await _DbContext.SaveChangesAsync(); //Live DB 
            if (res > 0)
            {
                await ExecuteStoredProcedure(OrderNo); // ✅ correct
                //return Ok("Order activated and SP executed successfully");
                return Ok("Order activated successfully");  // save the data through calling Sp 
            }
            return BadRequest("No changes were made");

            //return Ok("Order activated successfully");
        }
        [Authorize]
        [HttpGet("CheckDuplicateItem")]
        public async Task<IActionResult> CheckDuplicateItem(string orderId, string partyCode, string itemCode)
        {
            bool exists = await _Dbcontext.SalesOrderForMobiles
                .AnyAsync(x =>
                    x.OrderNo == orderId &&
                    x.PartyCode == partyCode &&
                    x.ItemCode == itemCode);

            return Ok(exists);
        }

        [Authorize]
        [HttpDelete("DeleteOrder/{orderNo}/{salesOrderUID}")]
        public async Task<IActionResult> DeleteOrder(string orderNo, Guid salesOrderUID)
        {
            var orders = await _Dbcontext.SalesOrderForMobiles  //Live DB 
                .Where(x => x.OrderNo == orderNo && x.SalesOrderUid == salesOrderUID)
                .ToListAsync();

            if (!orders.Any())
                return NotFound("Order not found");

            _Dbcontext.SalesOrderForMobiles.RemoveRange(orders);
            await _TestDbContext.SaveChangesAsync();

            return Ok("Order deleted successfully");
        }
        [Authorize]
        [HttpGet("GetLastOrder")]
        public async Task<IActionResult> GetLastOrder()
        {
             var last = await _Dbcontext.SalesOrderForMobiles  //Live DB
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new { x.OrderNo })
                .FirstOrDefaultAsync();

            return Ok(last);
        }
        [Authorize]
        [HttpGet("GetOrderbyPartyForDay/{orderDate}")]
        public async Task<IActionResult> GetOrderbyPartyForDay(DateTime orderDate, [FromQuery] string PartyCode, [FromQuery] string PartyName)
        {
            //if (!DateTime.TryParse(orderDate, out var parsedDate))
            //    return BadRequest("Invalid date format"); 

            Live DB
            var last = await _Dbcontext.SalesOrderForMobiles.Where(x => x.OrderDate.Date == orderDate.Date && x.PartyCode == PartyCode && x.PartyName == PartyName && x.IsActive == true)
                //.OrderByDescending(x => x.CreatedDate)
                .Select(x => new
                {
                    x.ItemCode,
                    x.ItemDescription,
                    x.Quantity,
                    x.Remarks
                })
                .ToListAsync();

            return Ok(last);
        }
        [Authorize]
        [HttpGet("GetGroupSizesByCategory")]
        public async Task<IActionResult> GetGroupSizesByCategory(string category)
        {
            var sizes = await _Dbcontext.ShoeSizes  //Live DB
                       .Where(x => x.Category == category)
                       .Select(x => x.GroupSize)
                       .Distinct()
                       .ToListAsync();


            var orderedSizes = sizes
      .Select(x =>
      {
          var parts = x.Split('-');
          bool isRange = parts.Length > 1;

          int start = int.Parse(parts[0]);
          int end = isRange ? int.Parse(parts[1]) : start;

          return new
          {
              Original = x,
              IsRange = isRange,
              Start = start,
              End = end
          };
      })
      .OrderBy(x => x.IsRange)      // 🔥 singles first (false before true)
      .ThenBy(x => x.Start)         // sort by start number
      .ThenBy(x => x.End)           // sort by end number
      .Select(x => x.Original)
      .ToList();


            return Ok(orderedSizes);
        }
        [Authorize]
        [HttpGet("GetSizesByCategory")]
        public async Task<IActionResult> GetSizesByCategory(string category)
        {
            var sizes = await _Dbcontext.ShoeSizes  //Live DB
                    .Where(x => x.Category == category)
                    .Select(x => x.ShoeSize1)
                    .Distinct()
                    .OrderBy(x => x)   // ensure sorted first
                    .ToListAsync();

            int startSize = 5;

            var reorderedSizes = sizes
                .Where(x => x >= startSize)
                .Concat(sizes.Where(x => x < startSize))
                .ToList();

            return Ok(reorderedSizes);
        }



        [Authorize]
        [HttpGet("GetColorsByCategory")]
        public async Task<IActionResult> GetColorsByCategory(string category)
        {
            var colorStrings = await _Dbcontext.ShoeSizes  //Live DB 
        .Where(x => x.Category == category).OrderBy(x => x.Color)
        .Select(x => x.Color)
        .ToListAsync();   // DB call ends here

            var colors = colorStrings
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .SelectMany(c => c.Split(',', StringSplitOptions.RemoveEmptyEntries))
                .Select(c => c.Trim())
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return Ok(colors);
        }

        [Authorize]
        [HttpPost("ExecuteStoredProcedure/{OrderNo}")]
        public async Task<IActionResult> ExecuteStoredProcedure(string OrderNo)
        {

            try
            {
                await _Dbcontext.Database.ExecuteSqlRawAsync(  //Live DB
                    "EXEC InsertSalesOrderFromMobileAppData @OrderNo",
                    new SqlParameter("@OrderNo", OrderNo)
                );

                return Ok("Procedure Executed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
