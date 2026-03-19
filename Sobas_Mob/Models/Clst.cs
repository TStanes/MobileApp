using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Clst")]
public partial class Clst
{
    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDescription { get; set; }

    [StringLength(255)]
    public string? Batch { get; set; }

    public double? Book { get; set; }

    public double? MfgDays { get; set; }

    [Column("MRP")]
    public double? Mrp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MfgDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    [StringLength(255)]
    public string? SubGroupCode { get; set; }

    [StringLength(255)]
    public string? SubGroupname { get; set; }
}
