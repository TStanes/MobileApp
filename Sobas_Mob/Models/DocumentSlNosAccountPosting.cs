using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DocumentSlNos_AccountPosting")]
[Index("TransactionTypeCode", "DivisionCode", "BranchCode", "Yr", Name = "IX_Tran_DivCode_BrCode_Yr")]
public partial class DocumentSlNosAccountPosting
{
    [StringLength(50)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    public int Yr { get; set; }

    public int LastNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
