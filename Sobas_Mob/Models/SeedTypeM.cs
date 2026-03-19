using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SeedTypeM")]
public partial class SeedTypeM
{
    [Key]
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

    [InverseProperty("SeedTypeU")]
    public virtual ICollection<ItemSeedM> ItemSeedMs { get; set; } = new List<ItemSeedM>();
}
