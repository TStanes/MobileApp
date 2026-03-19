using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TABillRawExcelData")]
public partial class TabillRawExcelDatum
{
    public int? EmployeeCode { get; set; }

    public int? ExpenseId { get; set; }

    [Column("DA")]
    public double? Da { get; set; }

    public double? Fuel { get; set; }

    public double? LodgeRent { get; set; }

    public double? MobileCharges { get; set; }

    public double? PostageCharges { get; set; }

    public double? TollFees { get; set; }

    public double? Miscellaneous { get; set; }

    public double? TravelCompany { get; set; }

    public double? TravelPrivate { get; set; }

    public double? TravelPublic { get; set; }

    public double? VehicleRepairsMaintenance { get; set; }

    public double? Stationery { get; set; }

    public double? Others { get; set; }

    [StringLength(255)]
    public string? ApprovedDate { get; set; }

    [StringLength(255)]
    public string? SubmittedDate { get; set; }

    public double? ApprovedAmount { get; set; }

    [StringLength(255)]
    public string? RunDate { get; set; }

    public int? ApprovedBy { get; set; }

    public double? ApproveRef { get; set; }

    [StringLength(255)]
    public string? ApproveNotes { get; set; }
}
