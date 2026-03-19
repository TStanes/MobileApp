using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("edposting")]
public partial class Edposting
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    public string? StateCode { get; set; }

    [StringLength(255)]
    public string? Branchcode { get; set; }

    [StringLength(255)]
    public string? Divisioncode { get; set; }

    [Column("ItemUID")]
    [StringLength(255)]
    public string? ItemUid { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemCategoryCode { get; set; }

    public double? Value { get; set; }
}
