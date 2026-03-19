using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("Princ_Decl")]
public partial class PrincDecl
{
    [Column("stat")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Stat { get; set; }

    [Column("desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc { get; set; }
}
