using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ExportMonSale
{
    [StringLength(15)]
    public string? Monthyear { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CountryName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ProdVal { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? ExpVal { get; set; }
}
