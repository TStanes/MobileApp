using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ITSectionM")]
public partial class ItsectionM
{
    [Key]
    [Column("ITSectionUID")]
    public Guid ItsectionUid { get; set; }

    [Column("ITSectionCode")]
    [StringLength(50)]
    public string ItsectionCode { get; set; } = null!;

    [Column("ITSectionDesc")]
    [StringLength(150)]
    public string ItsectionDesc { get; set; } = null!;

    [StringLength(150)]
    public string PrintDescription { get; set; } = null!;

    [Column("TDSPer", TypeName = "decimal(18, 2)")]
    public decimal Tdsper { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? EduCessPer { get; set; }

    [Column("HCPer", TypeName = "decimal(18, 2)")]
    public decimal? Hcper { get; set; }

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

    [Column("TDSGlCodeUID")]
    public Guid? TdsglCodeUid { get; set; }

    [Column("CessGlCodeUID")]
    public Guid? CessGlCodeUid { get; set; }

    [Column("SurGlCodeUID")]
    public Guid? SurGlCodeUid { get; set; }

    [ForeignKey("CessGlCodeUid")]
    [InverseProperty("ItsectionMCessGlCodeUs")]
    public virtual AccountM? CessGlCodeU { get; set; }

    [ForeignKey("SurGlCodeUid")]
    [InverseProperty("ItsectionMSurGlCodeUs")]
    public virtual AccountM? SurGlCodeU { get; set; }

    [ForeignKey("TdsglCodeUid")]
    [InverseProperty("ItsectionMTdsglCodeUs")]
    public virtual AccountM? TdsglCodeU { get; set; }
}
