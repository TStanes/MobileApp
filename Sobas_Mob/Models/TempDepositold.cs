using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempDepositold")]
public partial class TempDepositold
{
    [Column("partycode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReceiptNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReceiptAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefundRectNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefundRectDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RefundAmount { get; set; }

    public bool IsRefreredVoucher { get; set; }
}
