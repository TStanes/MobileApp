using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("AccountMExtn")]
public partial class AccountMextn
{
    [Key]
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
    [InverseProperty("AccountMextn")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("CrScheduleUid")]
    [InverseProperty("AccountMextnCrScheduleUs")]
    public virtual ScheduleM CrScheduleU { get; set; } = null!;

    [ForeignKey("DrScheduleUid")]
    [InverseProperty("AccountMextnDrScheduleUs")]
    public virtual ScheduleM DrScheduleU { get; set; } = null!;
}
