using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SOHeaderHOApproved")]
public partial class SoheaderHoapproved
{
    [Key]
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

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? EstiamteDateofDespatch { get; set; }

    [Column("HORemarks")]
    [StringLength(150)]
    [Unicode(false)]
    public string Horemarks { get; set; } = null!;

    [Column("FwdBranchUID")]
    public Guid? FwdBranchUid { get; set; }

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
}
