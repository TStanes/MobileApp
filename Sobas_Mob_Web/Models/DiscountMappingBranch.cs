using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountMappingBranch")]
public partial class DiscountMappingBranch
{
    [Key]
    [Column("DiscountMappingBranchUID")]
    public Guid DiscountMappingBranchUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

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
    public DateTime? RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifieddate { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("DiscountMappingBranches")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DiscountUid")]
    [InverseProperty("DiscountMappingBranches")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
