using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GSTPurchaseTemplate")]
public partial class GstpurchaseTemplate
{
    [Column("Document Type")]
    [StringLength(50)]
    public string? DocumentType { get; set; }

    [Column("Document Number")]
    [StringLength(50)]
    public string? DocumentNumber { get; set; }

    [Column("Document Date")]
    [StringLength(50)]
    public string? DocumentDate { get; set; }

    [Column("Return Filing Month")]
    [StringLength(50)]
    public string? ReturnFilingMonth { get; set; }

    [Column("Place of Supply")]
    [StringLength(150)]
    public string? PlaceOfSupply { get; set; }

    [Column("Is this a Bill of Supply")]
    public bool? IsThisABillOfSupply { get; set; }

    [Column("Is Reverse Charge")]
    public bool? IsReverseCharge { get; set; }

    [Column("Supplier GSTIN")]
    [StringLength(50)]
    public string? SupplierGstin { get; set; }

    [Column("Supplier Name")]
    [StringLength(150)]
    public string? SupplierName { get; set; }

    [Column("Supplier Address")]
    [StringLength(300)]
    public string? SupplierAddress { get; set; }

    [Column("Supplier City")]
    [StringLength(100)]
    public string? SupplierCity { get; set; }

    [Column("Supplier State")]
    [StringLength(100)]
    public string? SupplierState { get; set; }

    [Column("Is Supplier Composition Dealer")]
    [StringLength(10)]
    public string? IsSupplierCompositionDealer { get; set; }

    [Column("My GSTIN")]
    [StringLength(50)]
    public string? MyGstin { get; set; }

    [Column("Item Category")]
    [StringLength(100)]
    public string? ItemCategory { get; set; }

    [Column("Item Description")]
    [StringLength(150)]
    public string? ItemDescription { get; set; }

    [Column("HSN or SAC Code")]
    [StringLength(50)]
    public string? HsnOrSacCode { get; set; }

    [Column("Item Quantity", TypeName = "decimal(18, 2)")]
    public decimal? ItemQuantity { get; set; }

    [Column("Item Unit Code")]
    [StringLength(50)]
    public string? ItemUnitCode { get; set; }

    [Column("Item Unit Price")]
    [StringLength(50)]
    public string? ItemUnitPrice { get; set; }

    [Column("Item Discount Amount")]
    [StringLength(50)]
    public string? ItemDiscountAmount { get; set; }

    [Column("Item Taxable Amount", TypeName = "decimal(18, 2)")]
    public decimal? ItemTaxableAmount { get; set; }

    [Column("Zero Tax Category")]
    [StringLength(50)]
    public string? ZeroTaxCategory { get; set; }

    [Column("CGST Rate", TypeName = "decimal(18, 3)")]
    public decimal? CgstRate { get; set; }

    [Column("CGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? CgstAmount { get; set; }

    [Column("SGST Rate", TypeName = "decimal(18, 3)")]
    public decimal? SgstRate { get; set; }

    [Column("SGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? SgstAmount { get; set; }

    [Column("IGST Rate", TypeName = "decimal(18, 3)")]
    public decimal? IgstRate { get; set; }

    [Column("IGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? IgstAmount { get; set; }

    [Column("CESS Rate", TypeName = "decimal(18, 3)")]
    public decimal? CessRate { get; set; }

    [Column("CESS Amount", TypeName = "decimal(18, 2)")]
    public decimal? CessAmount { get; set; }

    [Column("ITC Claim Type")]
    [StringLength(50)]
    public string? ItcClaimType { get; set; }

    [Column("ITC Claim CGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? ItcClaimCgstAmount { get; set; }

    [Column("ITC Claim SGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? ItcClaimSgstAmount { get; set; }

    [Column("ITC Claim IGST Amount", TypeName = "decimal(18, 2)")]
    public decimal? ItcClaimIgstAmount { get; set; }

    [Column("ITC Claim CESS Amount", TypeName = "decimal(18, 2)")]
    public decimal? ItcClaimCessAmount { get; set; }

    [Column("Purpose of Input")]
    [StringLength(100)]
    public string? PurposeOfInput { get; set; }

    [Column("Import Type")]
    [StringLength(100)]
    public string? ImportType { get; set; }

    [Column("Import Bill Number")]
    [StringLength(50)]
    public string? ImportBillNumber { get; set; }

    [Column("Import Bill Date")]
    [StringLength(50)]
    public string? ImportBillDate { get; set; }

    [Column("Import Port Code")]
    [StringLength(50)]
    public string? ImportPortCode { get; set; }

    [Column("Vendor Code")]
    [StringLength(100)]
    public string? VendorCode { get; set; }

    [Column("Voucher Number")]
    [StringLength(50)]
    public string? VoucherNumber { get; set; }

    [Column("Voucher Date")]
    [StringLength(50)]
    public string? VoucherDate { get; set; }

    [Column("Is this Document Deleted")]
    public bool? IsThisDocumentDeleted { get; set; }

    [Column("External Line Item ID")]
    [StringLength(50)]
    public string? ExternalLineItemId { get; set; }

    [Column("ERP Company Code")]
    [StringLength(50)]
    public string? ErpCompanyCode { get; set; }

    [Column("Voucher Created Date")]
    [StringLength(50)]
    public string? VoucherCreatedDate { get; set; }

    [Column("Voucher Modified Date")]
    [StringLength(50)]
    public string? VoucherModifiedDate { get; set; }

    [Column("Voucher Created By")]
    [StringLength(50)]
    public string? VoucherCreatedBy { get; set; }

    [Column("ERP Voucher Type")]
    [StringLength(50)]
    public string? ErpVoucherType { get; set; }

    [Column("ERP Business Place")]
    [StringLength(50)]
    public string? ErpBusinessPlace { get; set; }

    [Column("ERP Plant Code")]
    [StringLength(50)]
    public string? ErpPlantCode { get; set; }

    [Column("ERP Profit Center")]
    [StringLength(50)]
    public string? ErpProfitCenter { get; set; }

    [Column("Item Material Code")]
    [StringLength(50)]
    public string? ItemMaterialCode { get; set; }

    [Column("ERP Tax Code")]
    [StringLength(50)]
    public string? ErpTaxCode { get; set; }

    [Column("ERP Expense GL Code")]
    [StringLength(50)]
    public string? ErpExpenseGlCode { get; set; }

    [Column("ITC CGST GL Code")]
    [StringLength(50)]
    public string? ItcCgstGlCode { get; set; }

    [Column("ITC SGST GL Code")]
    [StringLength(50)]
    public string? ItcSgstGlCode { get; set; }

    [Column("ITC IGST GL Code")]
    [StringLength(50)]
    public string? ItcIgstGlCode { get; set; }

    [Column("ITC Cess GL Code")]
    [StringLength(10)]
    public string? ItcCessGlCode { get; set; }
}
