using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Productavgrate")]
public partial class Productavgrate
{
    [StringLength(255)]
    public string? TargetDescription { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDesc { get; set; }

    [Column("NRV")]
    public double? Nrv { get; set; }

    [StringLength(255)]
    public string? DivisionDesc { get; set; }

    public double? DivisionCode { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    [StringLength(255)]
    public string? ItemGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemGroupDesc { get; set; }
}
