using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("HDFC_Reverse_Data")]
public partial class HdfcReverseDatum
{
    [Column("Rev_A")]
    [StringLength(100)]
    public string? RevA { get; set; }

    [Column("Rev_B")]
    [StringLength(100)]
    public string? RevB { get; set; }

    [Column("Rev_C")]
    [StringLength(100)]
    public string? RevC { get; set; }

    [Column("Rev_D")]
    [StringLength(100)]
    public string? RevD { get; set; }

    [Column("Rev_E")]
    [StringLength(100)]
    public string? RevE { get; set; }

    [Column("Rev_F")]
    [StringLength(100)]
    public string? RevF { get; set; }

    [Column("Rev_G")]
    [StringLength(100)]
    public string? RevG { get; set; }

    [Column("Rev_H")]
    [StringLength(100)]
    public string? RevH { get; set; }

    [Column("Rev_I")]
    [StringLength(100)]
    public string? RevI { get; set; }

    [Column("Rev_J")]
    [StringLength(100)]
    public string? RevJ { get; set; }

    [Column("Rev_K")]
    [StringLength(100)]
    public string? RevK { get; set; }

    [Column("Rev_L")]
    [StringLength(100)]
    public string? RevL { get; set; }

    [Column("Rev_M")]
    [StringLength(100)]
    public string? RevM { get; set; }

    [Column("Rev_N")]
    [StringLength(100)]
    public string? RevN { get; set; }

    [Column("Rev_O")]
    [StringLength(100)]
    public string? RevO { get; set; }

    [Column("Rev_P")]
    [StringLength(100)]
    public string? RevP { get; set; }
}
