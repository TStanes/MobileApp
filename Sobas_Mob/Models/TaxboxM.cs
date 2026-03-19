using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TaxboxM")]
public partial class TaxboxM
{
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(255)]
    public string? Division { get; set; }

    [StringLength(4000)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDesc { get; set; }

    public double? PackCode { get; set; }

    [StringLength(255)]
    public string? PackDesc { get; set; }

    [StringLength(255)]
    public string? ItemGroupDesc { get; set; }
}
