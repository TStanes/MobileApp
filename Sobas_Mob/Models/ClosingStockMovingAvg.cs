using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ClosingStockMovingAvg
{
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

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

    [StringLength(10)]
    [Unicode(false)]
    public string ItemCategoryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemCategoryDesc { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ReceiptQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? IssueQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Stock { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? ClosingMovingAverage { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? ClosingStock { get; set; }
}
