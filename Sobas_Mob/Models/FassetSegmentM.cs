using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetSegmentM")]
public partial class FassetSegmentM
{
    [Key]
    [Column("FAssetSegmentUID")]
    public Guid FassetSegmentUid { get; set; }

    [Column("FAssetSubGroupUID")]
    public Guid FassetSubGroupUid { get; set; }

    [Column("FAssetSegmentCode")]
    [StringLength(50)]
    public string FassetSegmentCode { get; set; } = null!;

    [Column("FAssetSegmentDesc")]
    [StringLength(250)]
    public string FassetSegmentDesc { get; set; } = null!;

    [StringLength(250)]
    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("FassetSegmentU")]
    public virtual ICollection<FassetItemM> FassetItemMs { get; set; } = new List<FassetItemM>();

    [ForeignKey("FassetSubGroupUid")]
    [InverseProperty("FassetSegmentMs")]
    public virtual FassetSubGroupM FassetSubGroupU { get; set; } = null!;

    [InverseProperty("FassetSegmentU")]
    public virtual ICollection<FassetTransDetail> FassetTransDetails { get; set; } = new List<FassetTransDetail>();
}
