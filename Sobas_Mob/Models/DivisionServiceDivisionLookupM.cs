using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DivisionServiceDivisionLookupM")]
public partial class DivisionServiceDivisionLookupM
{
    [Column("DivisionUID")]
    [StringLength(255)]
    public string? DivisionUid { get; set; }

    public double? DivisionCode { get; set; }

    [StringLength(255)]
    public string? DivisionDesc { get; set; }

    [StringLength(255)]
    public string? Abbriviation { get; set; }

    [StringLength(255)]
    public string? ParentDivisionUid { get; set; }
}
