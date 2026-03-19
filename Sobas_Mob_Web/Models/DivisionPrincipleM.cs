using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DivisionPrincipleM")]
public partial class DivisionPrincipleM
{
    [Key]
    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("DivsionUID")]
    public Guid DivsionUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;

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

    [StringLength(10)]
    [Unicode(false)]
    public string? PrincipleCode { get; set; }

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<AreaSoitemGroup> AreaSoitemGroups { get; set; } = new List<AreaSoitemGroup>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<CreditDaysM> CreditDaysMs { get; set; } = new List<CreditDaysM>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<DealerDeposit> DealerDeposits { get; set; } = new List<DealerDeposit>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<DiscountPercentageallowed> DiscountPercentagealloweds { get; set; } = new List<DiscountPercentageallowed>();

    [ForeignKey("DivsionUid")]
    [InverseProperty("DivisionPrincipleMs")]
    public virtual DivisionM DivsionU { get; set; } = null!;

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<ItemDivisionPrincipleLink> ItemDivisionPrincipleLinks { get; set; } = new List<ItemDivisionPrincipleLink>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<OverdueDaysM> OverdueDaysMs { get; set; } = new List<OverdueDaysM>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<PartyCreditLimitM> PartyCreditLimitMs { get; set; } = new List<PartyCreditLimitM>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<StockPointCommisionAccountMapping> StockPointCommisionAccountMappings { get; set; } = new List<StockPointCommisionAccountMapping>();

    [InverseProperty("DivisionPrincipleU")]
    public virtual ICollection<StockPointCommissionDetail> StockPointCommissionDetails { get; set; } = new List<StockPointCommissionDetail>();
}
