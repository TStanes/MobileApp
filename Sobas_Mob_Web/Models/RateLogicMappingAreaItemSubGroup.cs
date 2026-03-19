using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("RateLogicMappingAreaItemSubGroup")]
public partial class RateLogicMappingAreaItemSubGroup
{
    [Key]
    [Column("RateLogicMappingAreaItemSubGroupUID")]
    public Guid RateLogicMappingAreaItemSubGroupUid { get; set; }

    [Column("RateLogicHdrUID")]
    public Guid RateLogicHdrUid { get; set; }

    [Column("AreaUID")]
    public Guid AreaUid { get; set; }

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
    [InverseProperty("RateLogicMappingAreaItemSubGroups")]
    public virtual RateLogicHdr RateLogicHdrU { get; set; } = null!;
}
