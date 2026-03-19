using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Divupd")]
public partial class Divupd
{
    public double? Employeeeid { get; set; }

    [StringLength(255)]
    public string? Divisionuid { get; set; }
}
