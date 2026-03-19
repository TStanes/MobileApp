using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwTabillApproval
{
    [Column("TabillUID")]
    public Guid TabillUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("VehicheUID")]
    public Guid? VehicheUid { get; set; }

    [StringLength(500)]
    public string TabillNo { get; set; } = null!;

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

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Todate { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(200)]
    public string EmployeeName { get; set; } = null!;

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [StringLength(200)]
    public string EmployeeDesignation { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VechicleNo { get; set; } = null!;

    [Column("ParentDivisionUID")]
    public Guid ParentDivisionUid { get; set; }
}
