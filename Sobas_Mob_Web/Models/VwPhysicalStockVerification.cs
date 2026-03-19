using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwPhysicalStockVerification
{
    [Column("PhysicalStockVerificationHeaderUID")]
    public Guid PhysicalStockVerificationHeaderUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AsOnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VerifiedBy { get; set; }

    public bool IsGenerateAutoAdj { get; set; }

    [Column("PhysicalStockVerificationDetailUID")]
    public Guid PhysicalStockVerificationDetailUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BookQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? GoodQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DamagedQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LeakageQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reason { get; set; }

    public bool IsActive { get; set; }
}
