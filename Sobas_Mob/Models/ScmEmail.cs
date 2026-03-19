using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ScmEmail")]
public partial class ScmEmail
{
    [StringLength(255)]
    public string? PartyCode { get; set; }

    [StringLength(255)]
    public string? PartyName { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }
}
