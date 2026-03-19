using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemStatusM")]
public partial class ItemStatusM
{
    [Key]
    [Column("ItemStatusUID")]
    public Guid ItemStatusUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemStatusCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("ItemStatusU")]
    public virtual ICollection<InventoryServiceTransList> InventoryServiceTransLists { get; set; } = new List<InventoryServiceTransList>();

    [InverseProperty("ItemStatusU")]
    public virtual ICollection<InventoryTransList> InventoryTransLists { get; set; } = new List<InventoryTransList>();
}
