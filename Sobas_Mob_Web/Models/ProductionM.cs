using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ProductionM")]
public partial class ProductionM
{
    [Key]
    [Column("ProductionUID")]
    public Guid ProductionUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LotNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string LotDesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("FinishedItemUID")]
    public Guid FinishedItemUid { get; set; }

    [Column("RawMatUID")]
    public Guid RawMatUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MixtureLotNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal MixtureQty { get; set; }

    [Column(TypeName = "decimal(10, 3)")]
    public decimal? MixtureMeasure { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal MixtureFraction { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Details { get; set; }

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

    [ForeignKey("BranchUid")]
    [InverseProperty("ProductionMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("FinishedItemUid")]
    [InverseProperty("ProductionMFinishedItemUs")]
    public virtual ItemM FinishedItemU { get; set; } = null!;

    [ForeignKey("RawMatUid")]
    [InverseProperty("ProductionMRawMatUs")]
    public virtual ItemM RawMatU { get; set; } = null!;
}
