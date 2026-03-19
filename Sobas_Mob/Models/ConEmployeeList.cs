using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConEmployeeList")]
public partial class ConEmployeeList
{
    [Column("Staff Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StaffCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("Head Quarter")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HeadQuarter { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Action { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmpCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DepartmentOrDivision { get; set; }

    [Column("Business Role")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BusinessRole { get; set; }
}
