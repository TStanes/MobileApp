using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPaymentMadeDetailsForScheme
{
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("VoucherMatchUID")]
    public Guid VoucherMatchUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DrDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DrDocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RealisationDate { get; set; }

    public int? PaymentMade { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AdjAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? UnAdjAmt { get; set; }
}
