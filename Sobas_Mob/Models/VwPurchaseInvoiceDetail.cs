using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPurchaseInvoiceDetail
{
    [Column("PurchaseInvoiceDetailUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceDetailUid { get; set; }

    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseInvoiceDate { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReceivingBranchCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedQty { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal SupplierInvRate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4Per { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Discount4 { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 3)")]
    public decimal Edper { get; set; }

    [Column("ED", TypeName = "decimal(18, 5)")]
    public decimal Ed { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 3)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCess", TypeName = "decimal(18, 5)")]
    public decimal Edcess { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 3)")]
    public decimal Vatper { get; set; }

    [Column("VAT", TypeName = "decimal(18, 5)")]
    public decimal Vat { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 3)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCess", TypeName = "decimal(18, 5)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCessPer { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CostValue { get; set; }

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

    [Column("SGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Sgstper { get; set; }

    [Column("SGST", TypeName = "decimal(18, 5)")]
    public decimal Sgst { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Cgstper { get; set; }

    [Column("CGST", TypeName = "decimal(18, 5)")]
    public decimal Cgst { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Igstper { get; set; }

    [Column("IGST", TypeName = "decimal(18, 5)")]
    public decimal Igst { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;
}
