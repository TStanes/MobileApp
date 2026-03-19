using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("CheckBlockingQuery")]
public partial class CheckBlockingQuery
{
    [Column("SessionUID")]
    public Guid SessionUid { get; set; }

    [Column("GroupUID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? GroupUid { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? BlockingQuery { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? RunningQuery { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Rundate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HostName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LoginName { get; set; }
}
