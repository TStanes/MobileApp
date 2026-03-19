using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("RateLogicHdr")]
[Index("RateLogicDesc", Name = "UQ_RateLogicDesc", IsUnique = true)]
public partial class RateLogicHdr
{
    [Key]
    [Column("RateLogicHdrUID")]
    public Guid RateLogicHdrUid { get; set; }

    [Column("RateLogicTypeUID")]
    public Guid RateLogicTypeUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string RateLogicDesc { get; set; } = null!;

    [Column("BatchMFGFrom", TypeName = "datetime")]
    public DateTime BatchMfgfrom { get; set; }

    [Column("BatchMFGTo", TypeName = "datetime")]
    public DateTime BatchMfgto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveToDate { get; set; }

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
    public DateTime RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefModifieddate { get; set; }

    [InverseProperty("RateLogicHdrU")]
    public virtual ICollection<RateLogicItemSubGroupLink> RateLogicItemSubGroupLinks { get; set; } = new List<RateLogicItemSubGroupLink>();

    [InverseProperty("RateLogicHdrU")]
    public virtual ICollection<RateLogicMappingAreaItemSubGroup> RateLogicMappingAreaItemSubGroups { get; set; } = new List<RateLogicMappingAreaItemSubGroup>();

    [InverseProperty("RateLogicHdrU")]
    public virtual ICollection<RateLogicMappingBranchItemSubGroup> RateLogicMappingBranchItemSubGroups { get; set; } = new List<RateLogicMappingBranchItemSubGroup>();
}
