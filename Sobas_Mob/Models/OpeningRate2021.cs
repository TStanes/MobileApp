using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("OpeningRate2021")]
public partial class OpeningRate2021
{
    [Column(TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListuid { get; set; }

    [Column("rate", TypeName = "decimal(18, 3)")]
    public decimal? Rate { get; set; }

    [Column("itemuid")]
    public Guid Itemuid { get; set; }

    [Column("branchuid")]
    public Guid Branchuid { get; set; }
}
