using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetGroupM")]
public partial class FassetGroupM
{
    [Key]
    [Column("FAssetGroupUID")]
    public Guid FassetGroupUid { get; set; }

    [Column("FAssetClassUID")]
    public Guid FassetClassUid { get; set; }

    [Column("FAssetGroupCode")]
    [StringLength(50)]
    public string FassetGroupCode { get; set; } = null!;

    [Column("FAssetGroupDesc")]
    [StringLength(250)]
    public string FassetGroupDesc { get; set; } = null!;

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

    [ForeignKey("FassetClassUid")]
    [InverseProperty("FassetGroupMs")]
    public virtual FassetClassM FassetClassU { get; set; } = null!;

    [InverseProperty("FassetGroupU")]
    public virtual ICollection<FassetSubGroupM> FassetSubGroupMs { get; set; } = new List<FassetSubGroupM>();
}
