using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TransactionTypePurposeDetailM")]
public partial class TransactionTypePurposeDetailM
{
    [Key]
    [Column("TransactionTypePurposeTranUID")]
    public Guid TransactionTypePurposeTranUid { get; set; }

    [Column("TransactionTypePurposeUID")]
    public Guid TransactionTypePurposeUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Purpose { get; set; } = null!;

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

    public bool? IsAccountPostingNeeded { get; set; }

    [InverseProperty("PurposeU")]
    public virtual ICollection<BranchCreditNoteRegularApproval> BranchCreditNoteRegularApprovals { get; set; } = new List<BranchCreditNoteRegularApproval>();

    [InverseProperty("PurposeU")]
    public virtual ICollection<BranchCreditNoteRegularRequest> BranchCreditNoteRegularRequests { get; set; } = new List<BranchCreditNoteRegularRequest>();

    [InverseProperty("TransactionTypePurposeTranU")]
    public virtual ICollection<DrCrCodeSelect> DrCrCodeSelects { get; set; } = new List<DrCrCodeSelect>();

    [ForeignKey("TransactionTypePurposeUid")]
    [InverseProperty("TransactionTypePurposeDetailMs")]
    public virtual TransactionTypePurposeHeaderM TransactionTypePurposeU { get; set; } = null!;

    [InverseProperty("TransactionTypePurposeTranU")]
    public virtual ICollection<VoucherHeader> VoucherHeaders { get; set; } = new List<VoucherHeader>();
}
