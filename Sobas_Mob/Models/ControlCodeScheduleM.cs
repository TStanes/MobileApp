using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ControlCodeScheduleM")]
public partial class ControlCodeScheduleM
{
    [Key]
    [Column("ControlCodeScheduleUID")]
    public Guid ControlCodeScheduleUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("DrScheduleUID")]
    public Guid DrScheduleUid { get; set; }

    [Column("CrScheduleUID")]
    public Guid CrScheduleUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("AccountUid")]
    [InverseProperty("ControlCodeScheduleMs")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("CrScheduleUid")]
    [InverseProperty("ControlCodeScheduleMCrScheduleUs")]
    public virtual ScheduleM CrScheduleU { get; set; } = null!;

    [ForeignKey("DrScheduleUid")]
    [InverseProperty("ControlCodeScheduleMDrScheduleUs")]
    public virtual ScheduleM DrScheduleU { get; set; } = null!;
}
