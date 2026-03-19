using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TabIllRawData1")]
public partial class TabIllRawData1
{
    [Column("TabillRawUID")]
    public Guid TabillRawUid { get; set; }

    [Column("TabillRawID")]
    public int TabillRawId { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal EmployeeId { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal ExpenseId { get; set; }

    [Column("DA", TypeName = "decimal(18, 2)")]
    public decimal Da { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Fuel { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal LodgeRent { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PostageCharges { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TollFees { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MiscellaneousExpenses { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelCompanyVehicle { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelOwnVehicle { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TravelPublicTransport { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MobileCharges { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal VehicleMaintenance { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal StationeryExpense { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherExpenses { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TaBill { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ApprovedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SubmittedDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DeductedAmount { get; set; }

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

    [StringLength(10)]
    public string FinalFlag { get; set; } = null!;

    [StringLength(50)]
    public string FileName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FileRunDate { get; set; }
}
