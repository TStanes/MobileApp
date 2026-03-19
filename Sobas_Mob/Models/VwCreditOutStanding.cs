using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwCreditOutStanding
{
    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("PartyGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyGlcode { get; set; }

    [Column("VoucherMatchUID")]
    public Guid VoucherMatchUid { get; set; }

    public Guid TransType { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AdjAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OutStanding { get; set; }
}
