using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("EDSQtyCalculationTable")]
public partial class EdsqtyCalculationTable
{
    [StringLength(50)]
    public string? BranchCode { get; set; }

    [Column("itemcode")]
    [StringLength(50)]
    public string? Itemcode { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Receipt { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Issue { get; set; }
}
