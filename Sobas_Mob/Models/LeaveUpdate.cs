using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("LeaveUpdate")]
public partial class LeaveUpdate
{
    [Column("SNO")]
    public double? Sno { get; set; }

    [Column("EID")]
    public double? Eid { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("CL")]
    public double? Cl { get; set; }

    [Column("SL")]
    public double? Sl { get; set; }
}
