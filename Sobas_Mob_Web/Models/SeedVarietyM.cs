using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SeedVarietyM")]
public partial class SeedVarietyM
{
    [Key]
    [Column("SeedVarietyUID")]
    public Guid SeedVarietyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SeedVariety { get; set; } = null!;

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

    [StringLength(50)]
    [Unicode(false)]
    public string? Crop { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Duration { get; set; }

    [InverseProperty("SeedVarietyU")]
    public virtual ICollection<ItemSeedM> ItemSeedMs { get; set; } = new List<ItemSeedM>();
}
