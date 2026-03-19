using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwPurchaseOrder
{
    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PoheaderUid { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pono { get; set; } = null!;

    [Column("PODate", TypeName = "datetime")]
    public DateTime Podate { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SupplierCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Supplier { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RefNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string InvPacking { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Insurance { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Freight { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Others { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PaymentTerms { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Carrier { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DeliveryType { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalDiscount4 { get; set; }

    [Column("TotalED", TypeName = "decimal(18, 3)")]
    public decimal TotalEd { get; set; }

    [Column("TotalEDCess", TypeName = "decimal(18, 3)")]
    public decimal TotalEdcess { get; set; }

    [Column("TotalVAT", TypeName = "decimal(18, 3)")]
    public decimal TotalVat { get; set; }

    [Column("TotalVATCess", TypeName = "decimal(18, 3)")]
    public decimal TotalVatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalSecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalNetAmount { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column("POIndentUID", TypeName = "decimal(18, 0)")]
    public decimal PoindentUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IndentNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IndentDate { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? StockInHand { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? PendingOrderQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? RequiredQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? ApprovedQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejectedDate { get; set; }

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

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RequestedBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RequestedBranchName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OrderQty { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedQty { get; set; }

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
    public decimal DiscountPer { get; set; }

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
    public decimal NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CostValue { get; set; }

    [Column("PurchaseOrderAdvanceUID", TypeName = "decimal(18, 0)")]
    public decimal? PurchaseOrderAdvanceUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdvanceAmount { get; set; }

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
