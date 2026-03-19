using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("VocuherDetailPaise")]
public partial class VocuherDetailPaise
{
    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }
}
