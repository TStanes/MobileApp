using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwItemM
{
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PackCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PackDesc { get; set; } = null!;

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemCategoryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemCategoryDesc { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemSegmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSegmentDesc { get; set; } = null!;

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [Column("UOMUID")]
    public Guid Uomuid { get; set; }

    [Column("UOMCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uomcode { get; set; } = null!;

    [Column("UOMDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Uomdesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

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

    [StringLength(10)]
    [Unicode(false)]
    public string ChemicalCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ChemicalDesc { get; set; } = null!;

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

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

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

    [Column("IsED")]
    public bool IsEd { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConversionFactor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OldItemCode { get; set; }

    public bool? IsExpiryDt { get; set; }
}
