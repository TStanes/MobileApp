using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class View1
{
    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("UOMUID")]
    public Guid Uomuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    public bool IsFillMaterial { get; set; }

    [Column("ABCClass")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Abcclass { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? NoOfPack { get; set; }

    [Column("ROL", TypeName = "decimal(10, 2)")]
    public decimal? Rol { get; set; }

    [Column("ROQ", TypeName = "decimal(10, 2)")]
    public decimal? Roq { get; set; }

    [Column("EOQ", TypeName = "decimal(10, 2)")]
    public decimal? Eoq { get; set; }

    [Column("ChemicalUID")]
    public Guid? ChemicalUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Specification { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionReason { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool IsActive { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? OldItemCode { get; set; }

    [Column("IsED")]
    public bool IsEd { get; set; }

    [Column("UOM2UID")]
    public Guid? Uom2uid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Expr1 { get; set; } = null!;
}
