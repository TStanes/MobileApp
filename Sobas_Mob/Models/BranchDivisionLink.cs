using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchDivisionLink")]
public partial class BranchDivisionLink
{
    [Key]
    [Column("BranchDivisionLinkUID")]
    public Guid BranchDivisionLinkUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("SundryDebtorsUID")]
    public Guid? SundryDebtorsUid { get; set; }

    [Column("SundryCreditorsUID")]
    public Guid? SundryCreditorsUid { get; set; }

    [Column("DealerDepositUID")]
    public Guid? DealerDepositUid { get; set; }

    [Column("ImprestCodeUID")]
    public Guid? ImprestCodeUid { get; set; }

    [Column("SpecialImprestCodeUID")]
    public Guid? SpecialImprestCodeUid { get; set; }

    [Column("PostageImprestUID")]
    public Guid? PostageImprestUid { get; set; }

    [Column("SOSImprestUID")]
    public Guid? SosimprestUid { get; set; }

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
    [InverseProperty("BranchDivisionLinks")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DealerDepositUid")]
    [InverseProperty("BranchDivisionLinkDealerDepositUs")]
    public virtual AccountM? DealerDepositU { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("BranchDivisionLinks")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("ImprestCodeUid")]
    [InverseProperty("BranchDivisionLinkImprestCodeUs")]
    public virtual AccountM? ImprestCodeU { get; set; }

    [ForeignKey("PostageImprestUid")]
    [InverseProperty("BranchDivisionLinkPostageImprestUs")]
    public virtual AccountM? PostageImprestU { get; set; }

    [ForeignKey("SosimprestUid")]
    [InverseProperty("BranchDivisionLinkSosimprestUs")]
    public virtual AccountM? SosimprestU { get; set; }

    [ForeignKey("SpecialImprestCodeUid")]
    [InverseProperty("BranchDivisionLinkSpecialImprestCodeUs")]
    public virtual AccountM? SpecialImprestCodeU { get; set; }

    [ForeignKey("SundryCreditorsUid")]
    [InverseProperty("BranchDivisionLinkSundryCreditorsUs")]
    public virtual AccountM? SundryCreditorsU { get; set; }

    [ForeignKey("SundryDebtorsUid")]
    [InverseProperty("BranchDivisionLinkSundryDebtorsUs")]
    public virtual AccountM? SundryDebtorsU { get; set; }
}
