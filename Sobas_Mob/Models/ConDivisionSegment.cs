using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConDivisionSegment")]
public partial class ConDivisionSegment
{
    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("Division Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [Column("Division Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }

    [Column("Segment Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SegmentCode { get; set; }

    [Column("Segment Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SegmentName { get; set; }

    [Column("Division Prefix")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionPrefix { get; set; }
}
