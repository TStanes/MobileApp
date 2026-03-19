using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ChequeLodgementDetail1
{
    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LodgementDocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LodgementDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactiontypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TransactiontypeDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Purpose { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Details { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("PCRNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Pcrno { get; set; }

    [Column("PCRDate", TypeName = "datetime")]
    public DateTime? Pcrdate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string ModeDesc { get; set; } = null!;

    [Column("ChequeorDDNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeorDdno { get; set; }

    [Column("ChequeorDDDate", TypeName = "datetime")]
    public DateTime? ChequeorDddate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DebitBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DebitBranchName { get; set; } = null!;
}
