using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPurchaseInvoiceHeader
{
    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseInvoiceDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModeOfPurchase { get; set; } = null!;

    [Column("ReceivingBranchUID")]
    public Guid ReceivingBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBranchName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SupplierInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SupplierInvoiceDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InvPacking { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Insurance { get; set; }

    [Column("FrieghtPaymentTypeUID")]
    public Guid? FrieghtPaymentTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FrieghtPaymentCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FrieghtPaymentType { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal FrieghtPlus { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal FrieghtMinus { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal OtherDiscount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal HandlingCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PendingAdvanceAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount4 { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal ProductValue { get; set; }

    [Column("ED", TypeName = "decimal(18, 5)")]
    public decimal Ed { get; set; }

    [Column("CESS", TypeName = "decimal(18, 5)")]
    public decimal Cess { get; set; }

    [Column("VAT", TypeName = "decimal(18, 5)")]
    public decimal Vat { get; set; }

    [Column("VATCESS", TypeName = "decimal(18, 5)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Roundoff { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetAmount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal BillAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal DiffAmount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Reason { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AlreadyPaidAmt { get; set; }

    public bool VoucherGeneratedFlg { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal ClaimSettlement { get; set; }

    [Column("SGST", TypeName = "decimal(18, 5)")]
    public decimal Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(18, 5)")]
    public decimal Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 5)")]
    public decimal Igst { get; set; }
}
