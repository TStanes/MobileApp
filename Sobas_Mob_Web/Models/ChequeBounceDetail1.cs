using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class ChequeBounceDetail1
{
    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SoCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SoName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? AreaCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AreaDesc { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ChequeBounceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChequeBounceDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("ChequeOrDDNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeOrDdno { get; set; }

    [Column("ChequeOrDDDate", TypeName = "datetime")]
    public DateTime? ChequeOrDddate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BankAdDate { get; set; }

    [Column(TypeName = "decimal(19, 3)")]
    public decimal? BankCharge { get; set; }
}
