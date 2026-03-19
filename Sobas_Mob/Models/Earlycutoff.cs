using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Earlycutoff")]
public partial class Earlycutoff
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

    [Column("INVOICE NOS")]
    [StringLength(255)]
    public string? InvoiceNos { get; set; }

    [Column("Invoice Date", TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    public double? Qty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Amount { get; set; }

    [Column("LR_No")]
    [StringLength(255)]
    public string? LrNo { get; set; }

    [Column("LRDate")]
    [StringLength(255)]
    public string? Lrdate { get; set; }

    [Column("Mode of Realisation")]
    [StringLength(255)]
    public string? ModeOfRealisation { get; set; }

    [Column("Cheque No/RTGS/NEFT/ No")]
    [StringLength(255)]
    public string? ChequeNoRtgsNeftNo { get; set; }

    [Column("Date of Realisation")]
    [StringLength(255)]
    public string? DateOfRealisation { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amt { get; set; }

    [Column("lorryDate", TypeName = "datetime")]
    public DateTime? LorryDate { get; set; }

    [Column("lorryno", TypeName = "datetime")]
    public DateTime? Lorryno { get; set; }
}
