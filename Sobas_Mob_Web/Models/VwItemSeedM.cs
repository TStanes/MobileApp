using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwItemSeedM
{
    [Column("ItemSeedUID")]
    public Guid ItemSeedUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("SeedVarietyUID")]
    public Guid SeedVarietyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeedVariety { get; set; } = null!;

    [Column("SeedCategoryUID")]
    public Guid SeedCategoryUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeedCategory { get; set; } = null!;

    [Column("SeedTypeUID")]
    public Guid SeedTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeedType { get; set; } = null!;

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
}
