using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("RateLogicItemSubGroupLink")]
public partial class RateLogicItemSubGroupLink
{
    [Key]
    [Column("RateLogicItemSubGroupLinkUID")]
    public Guid RateLogicItemSubGroupLinkUid { get; set; }

    [Column("RateLogicHdrUID")]
    public Guid RateLogicHdrUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("MRPFromValue", TypeName = "decimal(18, 2)")]
    public decimal MrpfromValue { get; set; }

    [Column("MRPToValue", TypeName = "decimal(18, 2)")]
    public decimal MrptoValue { get; set; }

    [Column("MRPValue", TypeName = "decimal(18, 2)")]
    public decimal Mrpvalue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal FromValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ToValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Value { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MarginPer { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MarginAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Percentage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

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
    public DateTime RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefModifieddate { get; set; }

    [ForeignKey("RateLogicHdrUid")]
    [InverseProperty("RateLogicItemSubGroupLinks")]
    public virtual RateLogicHdr RateLogicHdrU { get; set; } = null!;
}
