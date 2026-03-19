using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("POSchedule")]
public partial class Poschedule
{
    [Key]
    [Column("POScheduleUID", TypeName = "decimal(18, 0)")]
    public decimal PoscheduleUid { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ScheduleDate { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal ScheduleQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal ReceivedQty { get; set; }

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

    [ForeignKey("PolineUid")]
    [InverseProperty("Poschedules")]
    public virtual Podetail PolineU { get; set; } = null!;
}
