using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("pdlist")]
public partial class Pdlist
{
    [Column("paRTYCODE")]
    [StringLength(255)]
    public string? PaRtycode { get; set; }
}
