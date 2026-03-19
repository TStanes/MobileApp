using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetItemM")]
public partial class FassetItemM
{
    [Key]
    [Column("FAssetItemUID")]
    public Guid FassetItemUid { get; set; }

    [Column("FAssetSegmentUID")]
    public Guid FassetSegmentUid { get; set; }

    [Column("FAssetItemCode")]
    [StringLength(50)]
    public string FassetItemCode { get; set; } = null!;

    [Column("FAssetItemDesc")]
    [StringLength(250)]
    public string FassetItemDesc { get; set; } = null!;

    [Column("ABCClass")]
    [StringLength(1)]
    public string? Abcclass { get; set; }

    [StringLength(250)]
    public string? Specification { get; set; }

    [StringLength(250)]
    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    [StringLength(250)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(250)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("FassetSegmentUid")]
    [InverseProperty("FassetItemMs")]
    public virtual FassetSegmentM FassetSegmentU { get; set; } = null!;
}
