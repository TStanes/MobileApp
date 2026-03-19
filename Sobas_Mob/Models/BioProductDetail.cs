using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BioProductDetail")]
public partial class BioProductDetail
{
    [Column("Item Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    [Column("Belongs To")]
    [StringLength(10)]
    [Unicode(false)]
    public string BelongsTo { get; set; } = null!;

    [Column("Grouped Under")]
    [StringLength(3)]
    [Unicode(false)]
    public string GroupedUnder { get; set; } = null!;

    [Column("Sub Group")]
    [StringLength(4)]
    [Unicode(false)]
    public string SubGroup { get; set; } = null!;

    [Column("Liquid/Powder")]
    [StringLength(255)]
    public string? LiquidPowder { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    public double? ReportSequence { get; set; }
}
