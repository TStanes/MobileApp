using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class GeneralLedgerView
{
    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string Particulars { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }
}
