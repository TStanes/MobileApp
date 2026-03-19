using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemCommodity")]
public partial class ItemCommodity
{
    [Key]
    [Column("ItemCommodityUID")]
    public Guid ItemCommodityUid { get; set; }

    [Column("CommodityUID")]
    public Guid CommodityUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

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

    [ForeignKey("CommodityUid")]
    [InverseProperty("ItemCommodities")]
    public virtual CommodityCodeM CommodityU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemCommodities")]
    public virtual ItemM ItemU { get; set; } = null!;
}
