using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SyncTimerList")]
public partial class SyncTimerList
{
    [Column("SyncTimerUID")]
    public Guid SyncTimerUid { get; set; }

    [Column("HOPushDataTimer")]
    public int HopushDataTimer { get; set; }

    [Column("HOPullDataTimer")]
    public int HopullDataTimer { get; set; }

    public int BranchUpLoadDataTimer { get; set; }

    public int BranchDownLoadDataTimer { get; set; }

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
