using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SchemeGeneration")]
public partial class SchemeGeneration
{
    [Key]
    [Column("SchemeGenerationUID")]
    public Guid SchemeGenerationUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

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
    [InverseProperty("SchemeGenerations")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DiscountUid")]
    [InverseProperty("SchemeGenerations")]
    public virtual DiscountM DiscountU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("SchemeGenerations")]
    public virtual DivisionM DivisionU { get; set; } = null!;
}
