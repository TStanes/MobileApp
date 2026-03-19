using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("StockLedgerWithRunningStock_Temp2_Status")]
public partial class StockLedgerWithRunningStockTemp2Status
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Itemcode { get; set; } = null!;
}
