using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DealerDeposit")]
public partial class DealerDeposit
{
    [Key]
    [Column("DealerDepositUID")]
    public Guid DealerDepositUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DlrDepRtno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DlrDepRtdt { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? DlrDepAmt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RefundNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefundDate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? RefundAmt { get; set; }

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

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("DealerDeposits")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;

    [ForeignKey("PartyUid")]
    [InverseProperty("DealerDeposits")]
    public virtual PartyM PartyU { get; set; } = null!;
}
