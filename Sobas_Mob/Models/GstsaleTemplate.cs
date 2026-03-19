using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GSTSaleTemplate")]
public partial class GstsaleTemplate
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

    [Column("Ecommerce GSTIN")]
    [StringLength(50)]
    public string? EcommerceGstin { get; set; }

    [Column("My GSTIN")]
    [StringLength(50)]
    public string? MyGstin { get; set; }

    [Column("Customer GSTIN")]
    [StringLength(50)]
    public string? CustomerGstin { get; set; }

    [Column("Customer Name")]
    [StringLength(100)]
    public string? CustomerName { get; set; }

    [Column("Customer Address")]
    [StringLength(300)]
    public string? CustomerAddress { get; set; }

    [Column("Customer City")]
    [StringLength(100)]
    public string? CustomerCity { get; set; }

    [Column("Customer State")]
    [StringLength(100)]
    public string? CustomerState { get; set; }

    [Column("Customer Taxpayer Type")]
    [StringLength(50)]
    public string? CustomerTaxpayerType { get; set; }

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

    [Column("Document Total Amount", TypeName = "decimal(18, 2)")]
    public decimal? DocumentTotalAmount { get; set; }

    [Column("Export Type")]
    [StringLength(50)]
    public string? ExportType { get; set; }

    [Column("Export Bill Number")]
    [StringLength(50)]
    public string? ExportBillNumber { get; set; }

    [Column("Export Bill Date")]
    [StringLength(50)]
    public string? ExportBillDate { get; set; }

    [Column("Export Port Code")]
    [StringLength(50)]
    public string? ExportPortCode { get; set; }

    [Column("Supplies u/s 9(5)")]
    [StringLength(100)]
    public string? SuppliesUS95 { get; set; }

    [Column("Voucher Number")]
    [StringLength(50)]
    public string? VoucherNumber { get; set; }

    [Column("Voucher Date")]
    [StringLength(50)]
    public string? VoucherDate { get; set; }

    [Column("Is this Document Cancelled")]
    public bool? IsThisDocumentCancelled { get; set; }

    [Column("External Line Item ID")]
    [StringLength(80)]
    public string? ExternalLineItemId { get; set; }

    [Column("ERP Company Code")]
    [StringLength(80)]
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

    [Column("Customer Code")]
    [StringLength(50)]
    public string? CustomerCode { get; set; }

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

    [Column("ERP Revenue GL Code")]
    [StringLength(50)]
    public string? ErpRevenueGlCode { get; set; }

    [Column("Output CGST GL Code")]
    [StringLength(50)]
    public string? OutputCgstGlCode { get; set; }

    [Column("Output SGST GL Code")]
    [StringLength(50)]
    public string? OutputSgstGlCode { get; set; }

    [Column("Output IGST GL Code")]
    [StringLength(50)]
    public string? OutputIgstGlCode { get; set; }

    [Column("Output Cess GL Code")]
    [StringLength(50)]
    public string? OutputCessGlCode { get; set; }
}
