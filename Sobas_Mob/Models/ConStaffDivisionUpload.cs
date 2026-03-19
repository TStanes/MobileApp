using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConStaffDivisionUpload")]
public partial class ConStaffDivisionUpload
{
    [Column("Staff Code")]
    public int? StaffCode { get; set; }

    [Column("Staff Name")]
    [StringLength(200)]
    public string? StaffName { get; set; }

    [Column("Division Code")]
    [StringLength(10)]
    public string? DivisionCode { get; set; }

    [Column("Division Name")]
    [StringLength(200)]
    public string? DivisionName { get; set; }
}
