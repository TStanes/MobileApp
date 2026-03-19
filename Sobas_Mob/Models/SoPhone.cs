using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SoPhone")]
public partial class SoPhone
{
    [StringLength(255)]
    public string? EmpCode { get; set; }

    [StringLength(255)]
    public string? EmpName { get; set; }

    [StringLength(15)]
    public string? MobileNo { get; set; }
}
