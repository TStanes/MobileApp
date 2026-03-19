using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountItemLink")]
public partial class DiscountItemLink
{
    [Key]
    [Column("DiscountItemLinkUID")]
    public Guid DiscountItemLinkUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifieddate { get; set; }

    [ForeignKey("DiscountUid")]
    [InverseProperty("DiscountItemLinks")]
    public virtual DiscountM DiscountU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("DiscountItemLinks")]
    public virtual DivisionM? DivisionU { get; set; }

    [ForeignKey("ItemGroupUid")]
    [InverseProperty("DiscountItemLinks")]
    public virtual ItemGroupM? ItemGroupU { get; set; }

    [ForeignKey("ItemSubGroupUid")]
    [InverseProperty("DiscountItemLinks")]
    public virtual ItemSubGroupM? ItemSubGroupU { get; set; }

    [ForeignKey("ItemUid")]
    [InverseProperty("DiscountItemLinks")]
    public virtual ItemM? ItemU { get; set; }
}
