using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempVoucher")]
public partial class TempVoucher
{
    [Column("FromBranchUID")]
    public Guid? FromBranchUid { get; set; }

    [Column("PostingUID")]
    public Guid? PostingUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DebitAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }
}
