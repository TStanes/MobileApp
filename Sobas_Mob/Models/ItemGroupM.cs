using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemGroupM")]
public partial class ItemGroupM
{
    [Key]
    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

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

    [InverseProperty("ItemGroupU")]
    public virtual ICollection<DiscountItemLink> DiscountItemLinks { get; set; } = new List<DiscountItemLink>();

    [InverseProperty("ItemGroupU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();

    [ForeignKey("ItemSegmentUid")]
    [InverseProperty("ItemGroupMs")]
    public virtual ItemSegmentM ItemSegmentU { get; set; } = null!;

    [InverseProperty("ItemGroupU")]
    public virtual ICollection<ItemSubGroupM> ItemSubGroupMs { get; set; } = new List<ItemSubGroupM>();

    [InverseProperty("ItemGroupU")]
    public virtual ICollection<TargetItemLinkMapping> TargetItemLinkMappings { get; set; } = new List<TargetItemLinkMapping>();

    [InverseProperty("ItemGroupU")]
    public virtual ICollection<TaxM> TaxMs { get; set; } = new List<TaxM>();
}
