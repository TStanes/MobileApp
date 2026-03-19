using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ScheduleM")]
public partial class ScheduleM
{
    [Key]
    [Column("ScheduleUID")]
    public Guid ScheduleUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ScheduleCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleAbbr { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string ScheduleDesc { get; set; } = null!;

    public bool IsGroup { get; set; }

    public int Level { get; set; }

    public int Order { get; set; }

    public bool? IsAdd { get; set; }

    public bool? IsTotal { get; set; }

    public bool? IsSubTotal { get; set; }

    public bool? IsLastTotal { get; set; }

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

    [Column("IsGroupedAS")]
    public int? IsGroupedAs { get; set; }

    [InverseProperty("CrScheduleU")]
    public virtual ICollection<AccountMextn> AccountMextnCrScheduleUs { get; set; } = new List<AccountMextn>();

    [InverseProperty("DrScheduleU")]
    public virtual ICollection<AccountMextn> AccountMextnDrScheduleUs { get; set; } = new List<AccountMextn>();

    [InverseProperty("CrScheduleU")]
    public virtual ICollection<ControlCodeScheduleM> ControlCodeScheduleMCrScheduleUs { get; set; } = new List<ControlCodeScheduleM>();

    [InverseProperty("DrScheduleU")]
    public virtual ICollection<ControlCodeScheduleM> ControlCodeScheduleMDrScheduleUs { get; set; } = new List<ControlCodeScheduleM>();
}
