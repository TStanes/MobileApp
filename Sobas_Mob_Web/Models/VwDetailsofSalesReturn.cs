using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDetailsofSalesReturn
{
    [StringLength(50)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("Credit Note No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CreditNoteNo { get; set; }

    [Column("Credit Note Date", TypeName = "datetime")]
    public DateTime? CreditNoteDate { get; set; }

    [Column("SALE INV.NO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SaleInvNo { get; set; }

    [Column("SALE INV.DATE", TypeName = "datetime")]
    public DateTime SaleInvDate { get; set; }

    [Column("SRN No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SrnNo { get; set; }

    [Column("SRN Date", TypeName = "datetime")]
    public DateTime SrnDate { get; set; }

    [Column("Name of the Customer")]
    [StringLength(172)]
    [Unicode(false)]
    public string? NameOfTheCustomer { get; set; }

    [StringLength(600)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Value { get; set; }

    [Column("VAT%", TypeName = "decimal(18, 2)")]
    public decimal Vat { get; set; }

    [Column("Is VAT Refund Eligible")]
    [StringLength(3)]
    [Unicode(false)]
    public string IsVatRefundEligible { get; set; } = null!;

    [Column("VAT Refund Amount", TypeName = "decimal(18, 3)")]
    public decimal VatRefundAmount { get; set; }

    [Column("VAT CESS %", TypeName = "decimal(18, 2)")]
    public decimal VatCess { get; set; }

    [Column("CESS Refund Amount", TypeName = "decimal(18, 3)")]
    public decimal CessRefundAmount { get; set; }

    [Column("Party DBN NO")]
    [StringLength(1)]
    [Unicode(false)]
    public string PartyDbnNo { get; set; } = null!;

    [Column("Party DBN DATE")]
    [StringLength(1)]
    [Unicode(false)]
    public string PartyDbnDate { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4Amt { get; set; }

    [Column("Total discount", TypeName = "decimal(21, 3)")]
    public decimal? TotalDiscount { get; set; }
}
