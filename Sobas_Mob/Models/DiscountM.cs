using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DiscountM")]
[Index("DivisionUid", "CreatedDate", "ModifiedDate", Name = "IX_DiscountM_DivisionUID_CreatedDate_ModifiedDate_Includes")]
[Index("DivisionUid", Name = "IX_DivsionUID")]
public partial class DiscountM
{
    [Key]
    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("DiscountTypeUID")]
    public Guid DiscountTypeUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DiscountDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("ParentDiscountUID")]
    public Guid? ParentDiscountUid { get; set; }

    public bool IsSingleInvoice { get; set; }

    public short DiscountFor { get; set; }

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

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    public int ProcessingTime { get; set; }

    public int ExtensionPeriod { get; set; }

    public bool IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifieddate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PrintDescription { get; set; } = null!;

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountItemLink> DiscountItemLinks { get; set; } = new List<DiscountItemLink>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingArea> DiscountMappingAreas { get; set; } = new List<DiscountMappingArea>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingBranch> DiscountMappingBranches { get; set; } = new List<DiscountMappingBranch>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingCountry> DiscountMappingCountries { get; set; } = new List<DiscountMappingCountry>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingDealerCategory> DiscountMappingDealerCategories { get; set; } = new List<DiscountMappingDealerCategory>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingDealer> DiscountMappingDealers { get; set; } = new List<DiscountMappingDealer>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountMappingState> DiscountMappingStates { get; set; } = new List<DiscountMappingState>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountPaymentMade> DiscountPaymentMades { get; set; } = new List<DiscountPaymentMade>();

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountQtyLift> DiscountQtyLifts { get; set; } = new List<DiscountQtyLift>();

    [ForeignKey("DiscountTypeUid")]
    [InverseProperty("DiscountMs")]
    public virtual DiscountTypeM DiscountTypeU { get; set; } = null!;

    [InverseProperty("DiscountU")]
    public virtual ICollection<DiscountValueLift> DiscountValueLifts { get; set; } = new List<DiscountValueLift>();

    [ForeignKey("DivisionUid")]
    [InverseProperty("DiscountMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("DiscountU")]
    public virtual ICollection<SchemeGeneration> SchemeGenerations { get; set; } = new List<SchemeGeneration>();
}
