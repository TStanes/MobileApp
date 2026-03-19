using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountMappingDealerCategory")]
public partial class DiscountMappingDealerCategory
{
    [Key]
    [Column("DiscountMappingDealerCategoryUID")]
    public Guid DiscountMappingDealerCategoryUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid DealerCategoryUid { get; set; }

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

    [ForeignKey("DealerCategoryUid")]
    [InverseProperty("DiscountMappingDealerCategories")]
    public virtual DealerCategoryM DealerCategoryU { get; set; } = null!;

    [ForeignKey("DiscountUid")]
    [InverseProperty("DiscountMappingDealerCategories")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
