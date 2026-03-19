using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BranchLinkedServerM")]
public partial class BranchLinkedServerM
{
    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    public string? BranchCode { get; set; }

    [StringLength(200)]
    public string? BranchName { get; set; }

    [StringLength(50)]
    public string? SyncLinkServerName { get; set; }

    [Column("SyncDBName")]
    [StringLength(50)]
    public string? SyncDbname { get; set; }

    [StringLength(50)]
    public string? BranchLinkServerName { get; set; }

    [Column("BranchDBName")]
    [StringLength(50)]
    public string? BranchDbname { get; set; }
}
