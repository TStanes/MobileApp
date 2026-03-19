using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ScheduleGroupM")]
public partial class ScheduleGroupM
{
    [Key]
    [Column("ScheduleGroupUID")]
    public Guid ScheduleGroupUid { get; set; }

    [Column("ScheduleUID")]
    public Guid ScheduleUid { get; set; }

    [Column("ParentScheduleUID")]
    public Guid ParentScheduleUid { get; set; }

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
}
