using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("LateCutoff")]
public partial class LateCutoff
{
    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [Column("Transaction Type")]
    [StringLength(255)]
    public string? TransactionType { get; set; }

    [Column("Item Code")]
    [StringLength(255)]
    public string? ItemCode { get; set; }

    [Column("Item Description")]
    [StringLength(255)]
    public string? ItemDescription { get; set; }

    [Column("Item Category")]
    [StringLength(255)]
    public string? ItemCategory { get; set; }

    [Column("Customer Name")]
    [StringLength(255)]
    public string? CustomerName { get; set; }

    [Column("INVOICE NO")]
    [StringLength(255)]
    public string? InvoiceNo { get; set; }

    [Column("Invoice Date", TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Amount { get; set; }

    [Column("LR/ No")]
    [StringLength(255)]
    public string? LrNo { get; set; }

    [Column("LR Date")]
    [StringLength(255)]
    public string? LrDate { get; set; }

    [Column("Mode of Realisation")]
    [StringLength(255)]
    public string? ModeOfRealisation { get; set; }

    [Column("Cheque No/RTGS/NEFT/ No")]
    [StringLength(255)]
    public string? ChequeNoRtgsNeftNo { get; set; }

    [Column("Date of Realisation")]
    [StringLength(255)]
    public string? DateOfRealisation { get; set; }
}
