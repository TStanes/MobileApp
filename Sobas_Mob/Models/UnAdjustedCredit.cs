using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class UnAdjustedCredit
{
    [Column("VoucherUID")]
    public Guid? VoucherUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TransactionTypeDesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AdjAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? UnAdjAmt { get; set; }
}
