using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("MonthEndProcessFlowHistory")]
public partial class MonthEndProcessFlowHistory
{
    [Key]
    [Column("monthendProcessFlowHistoryUID")]
    public Guid MonthendProcessFlowHistoryUid { get; set; }

    [Column("MonthEndStatusUID")]
    public Guid MonthEndStatusUid { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    public bool? IsProcessed { get; set; }

    public string? Remarks { get; set; }

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
