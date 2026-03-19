using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("InstalledVersion")]
public partial class InstalledVersion
{
    [StringLength(255)]
    public string? StaffCode { get; set; }

    public double? Phone { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? AppVersion { get; set; }
}
