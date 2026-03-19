using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class BatchStockDetail
{
    [StringLength(3)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ItemCategoryDesc { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? TotalQty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Over180Days { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Over1Year { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Over2Year { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Above3Year { get; set; }
}
