using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("conSalesOsCollParty")]
public partial class ConSalesOsCollParty
{
    public DateOnly? Date { get; set; }

    [Column("Customer Code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerCode { get; set; }

    [Column("Customer Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [Column("Division Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [Column("Division Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string DivisionName { get; set; } = null!;

    [Column("Credit Limit", TypeName = "decimal(38, 4)")]
    public decimal? CreditLimit { get; set; }

    [Column("Target Sales YTD")]
    public int? TargetSalesYtd { get; set; }

    [Column("Total Balance YTD", TypeName = "decimal(38, 3)")]
    public decimal? TotalBalanceYtd { get; set; }

    [Column("Total OverDue", TypeName = "decimal(38, 3)")]
    public decimal? TotalOverDue { get; set; }

    [Column("TotalCostYTD", TypeName = "decimal(38, 3)")]
    public decimal? TotalCostYtd { get; set; }

    [Column("CAGYTD", TypeName = "decimal(38, 3)")]
    public decimal? Cagytd { get; set; }

    [Column("GT180YTD", TypeName = "decimal(38, 3)")]
    public decimal? Gt180ytd { get; set; }

    [Column("Contact Phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ContactPhone { get; set; }

    [Column("Total Sales YTD")]
    public int? TotalSalesYtd { get; set; }

    [Column("Payment YTD")]
    public int? PaymentYtd { get; set; }

    [Column("socode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemSegmentName { get; set; }
}
