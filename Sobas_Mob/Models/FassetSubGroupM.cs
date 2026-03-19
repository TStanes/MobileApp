using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetSubGroupM")]
public partial class FassetSubGroupM
{
    [Key]
    [Column("FAssetSubGroupUID")]
    public Guid FassetSubGroupUid { get; set; }

    [Column("FAssetGroupUID")]
    public Guid FassetGroupUid { get; set; }

    [Column("FAssetSubGroupCode")]
    [StringLength(50)]
    public string FassetSubGroupCode { get; set; } = null!;

    [Column("FAssetSubGroupDesc")]
    [StringLength(250)]
    public string FassetSubGroupDesc { get; set; } = null!;

    [Column("VoucherDebitAccountUID")]
    public Guid VoucherDebitAccountUid { get; set; }

    [Column("DepreciationForFixedAccountUID")]
    public Guid DepreciationForFixedAccountUid { get; set; }

    [Column("ProvisionForDepreciationAccountUID")]
    public Guid ProvisionForDepreciationAccountUid { get; set; }

    [Column("SaleAccountUID")]
    public Guid SaleAccountUid { get; set; }

    public int LifeTimeInDays { get; set; }

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

    [ForeignKey("FassetGroupUid")]
    [InverseProperty("FassetSubGroupMs")]
    public virtual FassetGroupM FassetGroupU { get; set; } = null!;

    [InverseProperty("FassetSubGroupU")]
    public virtual ICollection<FassetSegmentM> FassetSegmentMs { get; set; } = new List<FassetSegmentM>();
}
