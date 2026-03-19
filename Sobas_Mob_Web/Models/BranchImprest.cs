using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BranchImprest")]
public partial class BranchImprest
{
    [Key]
    [Column("BranchImprestAmountUID")]
    public Guid BranchImprestAmountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("AccountUID")]
    public Guid? AccountUid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrImpAmt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrAddImpAmt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrPostImpAmt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BankBalance { get; set; }

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

    [Column("BrTAImpAmt", TypeName = "decimal(18, 0)")]
    public decimal BrTaimpAmt { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("BranchImprests")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("BranchImprests")]
    public virtual DivisionM DivisionU { get; set; } = null!;
}
