using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwBsschedule
{
    [Column("ScheduleUID")]
    public Guid ScheduleUid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string ScheduleDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleAbbr { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Amount { get; set; }
}
