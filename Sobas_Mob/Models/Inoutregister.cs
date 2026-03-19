using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class Inoutregister
{
    [Column("RowUID")]
    public Guid RowUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RefNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("HeaderID", TypeName = "decimal(18, 0)")]
    public decimal HeaderId { get; set; }

    [Column("RecordID", TypeName = "decimal(18, 0)")]
    public decimal RecordId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Column("Belongs_To")]
    [StringLength(10)]
    [Unicode(false)]
    public string BelongsTo { get; set; } = null!;

    [Column("Sub_Group")]
    [StringLength(4)]
    [Unicode(false)]
    public string SubGroup { get; set; } = null!;

    [Column("Grouped_Under")]
    [StringLength(3)]
    [Unicode(false)]
    public string GroupedUnder { get; set; } = null!;

    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? MovingAvg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdated { get; set; }

    [Column("RateDerivedID")]
    public int? RateDerivedId { get; set; }

    [Column("SNo")]
    public long Sno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(200)]
    public string? Remark { get; set; }

    [StringLength(60)]
    public string Batch { get; set; } = null!;

    [Column("MVGExp", TypeName = "decimal(18, 5)")]
    public decimal? Mvgexp { get; set; }

    [Column("OpenMVG", TypeName = "decimal(18, 5)")]
    public decimal? OpenMvg { get; set; }

    public bool? IsIssueMore { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? QtyIssuedMore { get; set; }
}
