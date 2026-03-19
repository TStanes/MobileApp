using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemSubGroupM")]
public partial class ItemSubGroupM
{
    [Key]
    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

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

    public bool? IsExpiryDt { get; set; }

    [InverseProperty("ItemSubGroupU")]
    public virtual ICollection<DiscountItemLink> DiscountItemLinks { get; set; } = new List<DiscountItemLink>();

    [ForeignKey("ItemGroupUid")]
    [InverseProperty("ItemSubGroupMs")]
    public virtual ItemGroupM ItemGroupU { get; set; } = null!;

    [InverseProperty("ItemSubGroupU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();

    [InverseProperty("ItemSubGroupU")]
    public virtual ICollection<TargetItemLinkMapping> TargetItemLinkMappings { get; set; } = new List<TargetItemLinkMapping>();

    [InverseProperty("ItemSubGroupU")]
    public virtual ICollection<TaxExemptedItemMaster> TaxExemptedItemMasters { get; set; } = new List<TaxExemptedItemMaster>();

    [InverseProperty("ItemSubGroupU")]
    public virtual ICollection<TaxM> TaxMs { get; set; } = new List<TaxM>();
}
