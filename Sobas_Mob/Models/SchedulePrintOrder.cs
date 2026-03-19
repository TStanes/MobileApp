using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SchedulePrintOrder")]
public partial class SchedulePrintOrder
{
    [Key]
    [Column("HOrder")]
    public int Horder { get; set; }

    [Column("ScheduleUID")]
    public Guid ScheduleUid { get; set; }
}
