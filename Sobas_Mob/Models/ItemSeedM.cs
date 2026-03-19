using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemSeedM")]
public partial class ItemSeedM
{
    [Key]
    [Column("ItemSeedUID")]
    public Guid ItemSeedUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("SeedVarietyUID")]
    public Guid SeedVarietyUid { get; set; }

    [Column("SeedCategoryUID")]
    public Guid SeedCategoryUid { get; set; }

    [Column("SeedTypeUID")]
    public Guid SeedTypeUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemSeedMs")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("SeedCategoryUid")]
    [InverseProperty("ItemSeedMs")]
    public virtual SeedCategoryM SeedCategoryU { get; set; } = null!;

    [ForeignKey("SeedTypeUid")]
    [InverseProperty("ItemSeedMs")]
    public virtual SeedTypeM SeedTypeU { get; set; } = null!;

    [ForeignKey("SeedVarietyUid")]
    [InverseProperty("ItemSeedMs")]
    public virtual SeedVarietyM SeedVarietyU { get; set; } = null!;
}
