using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DealerCategoryM")]
public partial class DealerCategoryM
{
    [Key]
    [Column("DealerCategoryUID")]
    public Guid DealerCategoryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DealerCategoryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DealerCategoryDesc { get; set; } = null!;

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

    [InverseProperty("DealerCategoryU")]
    public virtual ICollection<DealerCategoryItemRate> DealerCategoryItemRates { get; set; } = new List<DealerCategoryItemRate>();

    [InverseProperty("DealerCategoryU")]
    public virtual ICollection<DiscountMappingDealerCategory> DiscountMappingDealerCategories { get; set; } = new List<DiscountMappingDealerCategory>();

    [InverseProperty("DealerCategoryU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();
}
