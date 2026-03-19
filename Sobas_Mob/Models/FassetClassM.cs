using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetClassM")]
public partial class FassetClassM
{
    [Key]
    [Column("FAssetClassUID")]
    public Guid FassetClassUid { get; set; }

    [Column("FAssetClassCode")]
    [StringLength(50)]
    public string FassetClassCode { get; set; } = null!;

    [Column("FAssetClassDesc")]
    [StringLength(250)]
    public string FassetClassDesc { get; set; } = null!;

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

    [InverseProperty("FassetClassU")]
    public virtual ICollection<FassetGroupM> FassetGroupMs { get; set; } = new List<FassetGroupM>();
}
