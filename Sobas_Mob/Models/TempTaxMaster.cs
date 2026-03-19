using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempTaxMaster")]
public partial class TempTaxMaster
{
    [StringLength(255)]
    public string? DivisionUid { get; set; }

    [Column("itemuid")]
    [StringLength(255)]
    public string? Itemuid { get; set; }

    [Column("IGST")]
    public double? Igst { get; set; }

    [Column("CGST")]
    public double? Cgst { get; set; }

    [Column("SGST")]
    public double? Sgst { get; set; }

    [Column("LIGST")]
    public double? Ligst { get; set; }

    [Column("LCGST")]
    public double? Lcgst { get; set; }

    [Column("LSGST")]
    public double? Lsgst { get; set; }
}
