using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DICTopCrops")]
public partial class DictopCrop
{
    [Key]
    [Column("DICTopCropsUID")]
    public Guid DictopCropsUid { get; set; }

    [Column("DICUID")]
    public Guid Dicuid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NameOftheCrops { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Acerage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AveragenoofSprays { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ContibutionfortotalsalesinPer { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
