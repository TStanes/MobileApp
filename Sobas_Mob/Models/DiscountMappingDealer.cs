using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DiscountMappingDealer")]
[Index("CreatedDate", "ModifiedDate", Name = "IX_DiscountMappingDealer_CreatedDate_ModifiedDate_Includes")]
[Index("DiscountUid", Name = "IX_DiscountMappingDealer_DiscountUID")]
public partial class DiscountMappingDealer
{
    [Key]
    [Column("DiscountMappingDealerUID")]
    public Guid DiscountMappingDealerUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

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
    [InverseProperty("DiscountMappingDealers")]
    public virtual DiscountM DiscountU { get; set; } = null!;

    [ForeignKey("PartyUid")]
    [InverseProperty("DiscountMappingDealers")]
    public virtual PartyM PartyU { get; set; } = null!;
}
