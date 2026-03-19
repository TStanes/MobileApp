using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[PrimaryKey("StateUid", "BranchUid", "Letter")]
public partial class PartyCodeSlNo
{
    [Key]
    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Key]
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string Letter { get; set; } = null!;

    public int LastNo { get; set; }
}
