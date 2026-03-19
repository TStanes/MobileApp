using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchItemRate")]
public partial class BranchItemRate
{
    [Key]
    [Column("BranchItemRateUID")]
    public Guid BranchItemRateUid { get; set; }

    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
    public DateTime? RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifiedDate { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("BranchItemRates")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("ItemRateHeaderUid")]
    [InverseProperty("BranchItemRates")]
    public virtual ItemRateHeader ItemRateHeaderU { get; set; } = null!;
}
