using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class TabIllPaymentRequestDatum
{
    [Column("TAPayRequestID")]
    public int TapayRequestId { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("VehicheUID")]
    public Guid VehicheUid { get; set; }

    [Key]
    [Column("TabillRawID")]
    public int TabillRawId { get; set; }

    public int EmployeeCode { get; set; }

    public int ExpenseId { get; set; }

    [Column("DA", TypeName = "decimal(18, 2)")]
    public decimal Da { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Fuel { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal LodgeRent { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MobileCharges { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PostageCharges { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TollFees { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Miscellaneous { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelCompany { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelPrivate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelPublic { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal VehicleRepairsMaintenance { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Stationery { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Others { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ApprovedAmount { get; set; }

    [StringLength(30)]
    public string FinalFlag { get; set; } = null!;

    [StringLength(50)]
    public string VoucherReqNo { get; set; } = null!;

    [StringLength(50)]
    public string TaStatementNo { get; set; } = null!;

    [Column("paymentStatus")]
    public bool PaymentStatus { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
