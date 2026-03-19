using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ClosingStockVal")]
public partial class ClosingStockVal
{
    [Column("S NO")]
    public double? SNo { get; set; }

    [StringLength(255)]
    public string? Division { get; set; }

    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [Column("Item code")]
    [StringLength(255)]
    public string? ItemCode { get; set; }

    [Column("Item Description")]
    [StringLength(255)]
    public string? ItemDescription { get; set; }

    public double? Quantity { get; set; }

    [Column("Mvg Rate")]
    public double? MvgRate { get; set; }

    [Column("Mvg-value")]
    public double? MvgValue { get; set; }

    [Column("Processing ch value")]
    public double? ProcessingChValue { get; set; }

    public double? FrieghtValue { get; set; }

    [Column("Charges value")]
    public double? ChargesValue { get; set; }

    [Column("Final value")]
    public double? FinalValue { get; set; }

    [Column("Stock age")]
    public double? StockAge { get; set; }

    [Column("AGE")]
    [StringLength(255)]
    public string? Age { get; set; }

    [Column(" Category")]
    [StringLength(255)]
    public string? Category { get; set; }

    [StringLength(255)]
    public string? Remark { get; set; }
}
