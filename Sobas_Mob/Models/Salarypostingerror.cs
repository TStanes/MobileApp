using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SALARYPOSTINGERROR")]
public partial class Salarypostingerror
{
    [Column("ERROCODE")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? Errocode { get; set; }

    [Column("ERRMSG")]
    [Unicode(false)]
    public string? Errmsg { get; set; }
}
