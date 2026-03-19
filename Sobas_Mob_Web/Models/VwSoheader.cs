using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwSoheader
{
    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal SoheaderUid { get; set; }

    [Column("SONumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string Sonumber { get; set; } = null!;

    [Column("SODate", TypeName = "datetime")]
    public DateTime Sodate { get; set; }

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RequestBranchCode { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RequestBranchName { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSegmentDesc { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemGroupDesc { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSubGroupDesc { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AvailableQty { get; set; }

    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ApprovedQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ApprovedDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AmendPlusQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AmendMinusQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DespatchQty { get; set; }

    [Column("DespatchFromBranchUID")]
    public Guid? DespatchFromBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DespatchFromBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DespatchFromBranchName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? EstiamteDateofDespatch { get; set; }

    [Column("HORemarks")]
    [StringLength(150)]
    [Unicode(false)]
    public string Horemarks { get; set; } = null!;

    [Column("FwdBranchUID")]
    public Guid? FwdBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FwdBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string FwdBranchName { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StatusDesc { get; set; } = null!;

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
}
