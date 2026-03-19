using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ProductPromotionAllDatum
{
    [Column("FieldEmpID")]
    [StringLength(150)]
    public string FieldEmpId { get; set; } = null!;

    [StringLength(150)]
    public string FieldEmpName { get; set; } = null!;

    [StringLength(150)]
    public string? FatherName { get; set; }

    [StringLength(4)]
    public string? SoCode { get; set; }

    [StringLength(500)]
    public string? SoName { get; set; }

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

    public int PayMonth { get; set; }

    public int Payyear { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayFromDate { get; set; }

    [Column("payToDate", TypeName = "datetime")]
    public DateTime PayToDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RetainerFee { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Batta { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal FoodExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal VehicleReimb { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CompaighExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrintingExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Total { get; set; }
}
