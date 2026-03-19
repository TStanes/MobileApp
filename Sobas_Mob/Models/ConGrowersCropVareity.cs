using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConGrowersCropVareity")]
public partial class ConGrowersCropVareity
{
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeedVariety { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeedType { get; set; } = null!;

    [Column("Crop Category")]
    [StringLength(5)]
    [Unicode(false)]
    public string CropCategory { get; set; } = null!;

    [Column("Duration Classification")]
    [StringLength(14)]
    [Unicode(false)]
    public string DurationClassification { get; set; } = null!;
}
