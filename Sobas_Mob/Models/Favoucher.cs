using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("FAVoucher")]
public partial class Favoucher
{
    [Column("FromBranchUID")]
    public Guid? FromBranchUid { get; set; }

    [Column("PostingUID")]
    public Guid? PostingUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? AccountDesc { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DebitAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmount { get; set; }
}
