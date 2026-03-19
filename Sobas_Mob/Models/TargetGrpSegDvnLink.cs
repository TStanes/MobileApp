using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetGrpSegDvnLInk")]
public partial class TargetGrpSegDvnLink
{
    [Column("targetuid")]
    public Guid Targetuid { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string TargetDescription { get; set; } = null!;

    [StringLength(255)]
    public string? GroupDesc { get; set; }

    [StringLength(255)]
    public string? SegmentGroup { get; set; }

    [StringLength(255)]
    public string? FinancialGroup { get; set; }

    [StringLength(255)]
    public string? DivisionCode { get; set; }
}
