using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("StDecl")]
public partial class StDecl
{
    [Column("stcod")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Stcod { get; set; }

    [Column("decl")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Decl { get; set; }
}
