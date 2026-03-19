using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConGrowersEmployeeUniqueList")]
public partial class ConGrowersEmployeeUniqueList
{
    [Column("Staff Code")]
    public int StaffCode { get; set; }

    [StringLength(150)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("Head Quarter")]
    [StringLength(10)]
    [Unicode(false)]
    public string HeadQuarter { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Action { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DepartmentOrDivision { get; set; } = null!;
}
