using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CommodityCodeM")]
public partial class CommodityCodeM
{
    [Key]
    [Column("CommodityUID")]
    public Guid CommodityUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CommodityCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string CommodityCodeDesc { get; set; } = null!;

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

    [InverseProperty("CommodityU")]
    public virtual ICollection<ItemCommodity> ItemCommodities { get; set; } = new List<ItemCommodity>();

    [InverseProperty("CommodityU")]
    public virtual ICollection<StateCommodityM> StateCommodityMs { get; set; } = new List<StateCommodityM>();
}
