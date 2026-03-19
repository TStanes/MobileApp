using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DrCrCodeSelect")]
public partial class DrCrCodeSelect
{
    [Key]
    [Column("DrCrCodeSelectUID")]
    public Guid DrCrCodeSelectUid { get; set; }

    [Column("TransactionTypesUID")]
    public Guid TransactionTypesUid { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid TransactionTypePurposeTranUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

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
    [InverseProperty("DrCrCodeSelects")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("DrCrCodeSelects")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("DrCrCodeSelectU")]
    public virtual ICollection<DrcrcodeSelectLink> DrcrcodeSelectLinks { get; set; } = new List<DrcrcodeSelectLink>();

    [ForeignKey("TransactionTypePurposeTranUid")]
    [InverseProperty("DrCrCodeSelects")]
    public virtual TransactionTypePurposeDetailM TransactionTypePurposeTranU { get; set; } = null!;

    [ForeignKey("TransactionTypesUid")]
    [InverseProperty("DrCrCodeSelects")]
    public virtual TransactionTypesM TransactionTypesU { get; set; } = null!;
}
