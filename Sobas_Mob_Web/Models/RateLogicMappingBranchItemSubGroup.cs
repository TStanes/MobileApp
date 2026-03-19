using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("RateLogicMappingBranchItemSubGroup")]
public partial class RateLogicMappingBranchItemSubGroup
{
    [Key]
    [Column("RateLogicMappingBranchItemSubGroupUID")]
    public Guid RateLogicMappingBranchItemSubGroupUid { get; set; }

    [Column("RateLogicHdrUID")]
    public Guid RateLogicHdrUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

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
    [InverseProperty("RateLogicMappingBranchItemSubGroups")]
    public virtual RateLogicHdr RateLogicHdrU { get; set; } = null!;
}
