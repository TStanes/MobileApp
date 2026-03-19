using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDetailsofPurchaseReturn
{
    [Column("PUR. RTN. DOCNO.")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PurRtnDocno { get; set; }

    [Column("PUR.RTN.DOC.Date", TypeName = "datetime")]
    public DateTime PurRtnDocDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column("Name of the Supplier")]
    [StringLength(172)]
    [Unicode(false)]
    public string? NameOfTheSupplier { get; set; }

    [StringLength(600)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Value { get; set; }

    [Column("VAT%", TypeName = "decimal(18, 2)")]
    public decimal Vat { get; set; }

    [Column("VAT Refund Amount", TypeName = "decimal(18, 3)")]
    public decimal VatRefundAmount { get; set; }

    [Column("VAT CESS %", TypeName = "decimal(18, 2)")]
    public decimal VatCess { get; set; }

    [Column("CESS Refund Amount", TypeName = "decimal(18, 3)")]
    public decimal CessRefundAmount { get; set; }

    [Column("ORIGINAL PUR. INV.NO")]
    [StringLength(20)]
    [Unicode(false)]
    public string OriginalPurInvNo { get; set; } = null!;

    [Column("ORIGINAL.PUR.INV.Date", TypeName = "datetime")]
    public DateTime? OriginalPurInvDate { get; set; }

    [Column("GRN NO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? GrnNo { get; set; }

    [Column("GRN DATE", TypeName = "datetime")]
    public DateTime GrnDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("Party CreditNote No.")]
    [StringLength(1)]
    [Unicode(false)]
    public string PartyCreditNoteNo { get; set; } = null!;

    [Column("Credit No. Date")]
    [StringLength(1)]
    [Unicode(false)]
    public string CreditNoDate { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

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
