using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class TabIllRawDatum
{
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

    [Column(TypeName = "datetime")]
    public DateTime ApprovedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SubmittedDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ApprovedAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RunDate { get; set; }

    [StringLength(100)]
    public string ApprovedBy { get; set; } = null!;

    [StringLength(100)]
    public string ApproveRef { get; set; } = null!;

    [StringLength(300)]
    public string ApproveNotes { get; set; } = null!;

    [StringLength(30)]
    public string FinalFlag { get; set; } = null!;

    [StringLength(50)]
    public string FileName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FileRunDate { get; set; }

    public bool IsActive { get; set; }

    [Column("paymentStatus")]
    public bool PaymentStatus { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
