using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TABillApproval")]
[Index("BranchUid", Name = "IX_TABillApproval_BranchUID_Includes")]
[Index("EmployeeUid", Name = "IX_TABillApproval_EmployeeUID_Includes")]
[Index("RepairValue", "EmployeeUid", "VehicheUid", "DivisionUid", "BranchUid", "RequestNumber", Name = "_dta_index_TABillApproval_5_1619745073__K12_K2_K5_K4_K3_K23")]
[Index("Isactive", "FromDate", Name = "_dta_index_TABillApproval_5_1619745073__K26_K19_1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_20_21_22_23_24_25_27_28_29_30")]
[Index("TabillNo", Name = "_dta_index_TABillApproval_5_1619745073__K6")]
public partial class TabillApproval
{
    [Key]
    [Column("TabillUID")]
    public Guid TabillUid { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("VehicheUID")]
    public Guid? VehicheUid { get; set; }

    [StringLength(500)]
    public string? TabillNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal BusTrainFee { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RoomRent { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Postage { get; set; }

    [Column("DDCommision", TypeName = "decimal(18, 2)")]
    public decimal Ddcommision { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PetrolValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RepairValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Batta { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PhoneCharge { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Stationary { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherExps { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OilValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Total { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Todate { get; set; }

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(20)]
    public string RequestNumber { get; set; } = null!;

    [StringLength(10)]
    public string IsApproved { get; set; } = null!;

    [StringLength(500)]
    public string RejectedReason { get; set; } = null!;

    [StringLength(10)]
    public string Isactive { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
