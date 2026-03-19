using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("inoutregister")]
public partial class Inoutregister
{
    [Column("RowID")]
    public Guid? RowId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("HeaderID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HeaderId { get; set; }

    [Column("RecordID")]
    [StringLength(50)]
    [Unicode(false)]
    public string RecordId { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Category { get; set; }

    [Column("Belongs_To")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BelongsTo { get; set; }

    [Column("Sub_group")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SubGroup { get; set; }

    [Column("Grouped_Under")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GroupedUnder { get; set; }

    [Column("PartyID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? MovingAvg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [Column("RateDerivedID")]
    [StringLength(50)]
    public string? RateDerivedId { get; set; }

    [Column("SNo")]
    public int Sno { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [StringLength(30)]
    public string? Batch { get; set; }

    [Column("MVGExp", TypeName = "decimal(18, 5)")]
    public decimal? Mvgexp { get; set; }

    [Column("OpenMVG", TypeName = "decimal(18, 5)")]
    public decimal? OpenMvg { get; set; }

    public bool? IsIssueMore { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? QtyIssuedMore { get; set; }
}
