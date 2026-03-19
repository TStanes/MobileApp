using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DealerDepositwithoutRef")]
public partial class DealerDepositwithoutRef
{
    public double? DocumentNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocumentDate { get; set; }

    [Column("Party Code")]
    [StringLength(255)]
    public string? PartyCode { get; set; }

    [StringLength(255)]
    public string? PartyName { get; set; }

    [StringLength(255)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(255)]
    public string? Address3 { get; set; }

    [StringLength(255)]
    public string? Address4 { get; set; }

    [Column("branch code")]
    public double? BranchCode { get; set; }

    [Column("branch name")]
    [StringLength(255)]
    public string? BranchName { get; set; }

    [Column("catg")]
    [StringLength(255)]
    public string? Catg { get; set; }

    [StringLength(255)]
    public string? State { get; set; }

    [Column("Receipt No")]
    [StringLength(255)]
    public string? ReceiptNo { get; set; }

    [Column("Receipt Date", TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [Column("Receipt Amount")]
    public double? ReceiptAmount { get; set; }

    [Column("Refund Rect No")]
    [StringLength(255)]
    public string? RefundRectNo { get; set; }

    [StringLength(255)]
    public string? RefundRectDate { get; set; }

    [StringLength(255)]
    public string? RefundAmount { get; set; }

    [Column("DEP CODE")]
    [StringLength(255)]
    public string? DepCode { get; set; }
}
