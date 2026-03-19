using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("stockpos")]
public partial class Stockpo
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemHead { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemHeadDesc { get; set; } = null!;

    [Column("seedcategory")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Seedcategory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? OpeningBalance { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? PurchaseQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? ProdnRcptQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? StkTrfRcptQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? SlsRtnQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? OtherRcptQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? TotReceiptsQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? TotOpbRcptQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? SalesQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? StkTrfIssQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? ProdnIssQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? OthIssQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? TotIssueQty { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? ClosingBalance { get; set; }
}
