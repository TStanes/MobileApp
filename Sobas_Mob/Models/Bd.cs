using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BD")]
public partial class Bd
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    public string? Code { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public double? Amount { get; set; }

    [StringLength(255)]
    public string? Field4 { get; set; }
}
