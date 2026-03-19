using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwPurchaseInvoice
{
    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseInvoiceDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModeOfPurchase { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Abbriviation { get; set; } = null!;

    [Column("ReceivingBranchUID")]
    public Guid ReceivingBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBranchName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBrAddress1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBrAddress2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBrAddress3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBrAddress4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBrCity { get; set; } = null!;

    [Column("ReceivingBrStateUID")]
    public Guid ReceivingBrStateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBrStateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBrStateDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ReceivingBrTelephoneNo { get; set; } = null!;

    [Column("ReceivingBrCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBrCst { get; set; } = null!;

    [Column("ReceivingBrTIN")]
    [StringLength(20)]
    [Unicode(false)]
    public string ReceivingBrTin { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ReceivingBranchType { get; set; } = null!;

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SupplierInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SupplierInvoiceDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SupplierTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SupplierInitials { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierName { get; set; } = null!;

    [Column("SupplierGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierGlcode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierAddress1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SupplierAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SupplierCity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SupplierPinCode { get; set; }

    [Column("SupplierStateUID")]
    public Guid SupplierStateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SupplierStateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierStateDesc { get; set; } = null!;

    [Column("SupplierCountryUID")]
    public Guid SupplierCountryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierCountryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierCountryName { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierTelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierFaxNo { get; set; }

    [Column("SupplierTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string SupplierTinno { get; set; } = null!;

    [Column("SupplierLST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SupplierLst { get; set; }

    [Column("SupplierCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string SupplierCst { get; set; } = null!;

    [Column("SupplierPANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierPanno { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InvPacking { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Insurance { get; set; }

    [Column("FrieghtPaymentTypeUID")]
    public Guid? FrieghtPaymentTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FrieghtPaymentCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FrieghtPaymentType { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FrieghtPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FrieghtMinus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherDiscount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal HandlingCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PendingAdvanceAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalProductValue { get; set; }

    [Column("TotalED", TypeName = "decimal(18, 3)")]
    public decimal TotalEd { get; set; }

    [Column("TotalCESS", TypeName = "decimal(18, 3)")]
    public decimal TotalCess { get; set; }

    [Column("TotalVAT", TypeName = "decimal(18, 3)")]
    public decimal TotalVat { get; set; }

    [Column("TotalVATCESS", TypeName = "decimal(18, 3)")]
    public decimal TotalVatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalSecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Roundoff { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetAmount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BillAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DiffAmount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Reason { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AlreadyPaidAmt { get; set; }

    public bool VoucherGeneratedFlg { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ClaimSettlement { get; set; }

    [Column("CFormNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CformNo { get; set; }

    [Column("CFromDate", TypeName = "datetime")]
    public DateTime? CfromDate { get; set; }

    [Column("PurchaseInvoiceDetailUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceDetailUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemCategoryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemCategoryDesc { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemSegmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSegmentDesc { get; set; } = null!;

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal? PolineUid { get; set; }

    [Column("GRNQty", TypeName = "decimal(18, 5)")]
    public decimal Grnqty { get; set; }

    [Column("GRNReceiptReturnQty", TypeName = "decimal(18, 5)")]
    public decimal? GrnreceiptReturnQty { get; set; }

    [Column("GRNCarrierShortages", TypeName = "decimal(18, 5)")]
    public decimal GrncarrierShortages { get; set; }

    [Column("GRNMoistureqty", TypeName = "decimal(18, 5)")]
    public decimal Grnmoistureqty { get; set; }

    [Column("GRNNetQty", TypeName = "decimal(18, 5)")]
    public decimal GrnnetQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedQty { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SupplierInvRate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineGrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4 { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 3)")]
    public decimal Edper { get; set; }

    [Column("ED", TypeName = "decimal(18, 3)")]
    public decimal Ed { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 3)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCess", TypeName = "decimal(18, 3)")]
    public decimal Edcess { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 3)")]
    public decimal Vatper { get; set; }

    [Column("VAT", TypeName = "decimal(18, 3)")]
    public decimal Vat { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 3)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCess", TypeName = "decimal(18, 3)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineNetAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CostValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PostedValue { get; set; }

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
}
