using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("JDA")]
public partial class Jdum
{
    [StringLength(255)]
    public string? Partycode { get; set; }
}
