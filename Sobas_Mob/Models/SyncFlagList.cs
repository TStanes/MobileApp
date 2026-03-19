using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SyncFlagList")]
public partial class SyncFlagList
{
    [Column("SyncFlagUID")]
    public Guid SyncFlagUid { get; set; }

    [Column("HOPushDataFlag")]
    public bool HopushDataFlag { get; set; }

    [Column("HOPullDataFlag")]
    public bool HopullDataFlag { get; set; }

    public bool BranchUpLoadDataFlag { get; set; }

    public bool BranchDownLoadDataFlag { get; set; }
}
