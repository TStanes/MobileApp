using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemRateHeader")]
[Index("DivisionUid", Name = "IX_DivisionUID")]
[Index("ModifiedDate", Name = "IX_ItemRateHeader_ModifiedDate_Includes")]
public partial class ItemRateHeader
{
    [Key]
    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("ItemRateTypeUID")]
    public Guid ItemRateTypeUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemRateDesc { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BatchMFGFrom", TypeName = "datetime")]
    public DateTime BatchMfgfrom { get; set; }

    [Column("BatchMFGTo", TypeName = "datetime")]
    public DateTime BatchMfgto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("ParentItemRateHeaderUID")]
    public Guid? ParentItemRateHeaderUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PercentagePlus { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PercentageMinus { get; set; }

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

    public bool IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifiedDate { get; set; }

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<AreaItemRate> AreaItemRates { get; set; } = new List<AreaItemRate>();

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<BranchItemRate> BranchItemRates { get; set; } = new List<BranchItemRate>();

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<CountryItemRate> CountryItemRates { get; set; } = new List<CountryItemRate>();

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<DealerCategoryItemRate> DealerCategoryItemRates { get; set; } = new List<DealerCategoryItemRate>();

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<ItemRate> ItemRates { get; set; } = new List<ItemRate>();

    [InverseProperty("ItemRateHeaderU")]
    public virtual ICollection<StateItemRate> StateItemRates { get; set; } = new List<StateItemRate>();
}
