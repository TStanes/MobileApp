using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SeedCategoryM")]
public partial class SeedCategoryM
{
    [Key]
    [Column("SeedCategoryUID")]
    public Guid SeedCategoryUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeedCategory { get; set; } = null!;

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

    [InverseProperty("SeedCategoryU")]
    public virtual ICollection<ItemSeedM> ItemSeedMs { get; set; } = new List<ItemSeedM>();
}
