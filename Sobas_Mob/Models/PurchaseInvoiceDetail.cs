using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PurchaseInvoiceDetail")]
[Index("PurchaseInvoiceHeaderUid", Name = "IX_PurchaseHdr_NetAmt")]
[Index("PurchaseInvoiceHeaderUid", "PurchaseInvoiceDetailUid", "InventoryTransListUid", Name = "_dta_index_PurchaseInvoiceDetail_7_2123154609__K2_K1_K3")]
[Index("InventoryTransListUid", "IsActive", "PurchaseInvoiceDetailUid", "PurchaseInvoiceHeaderUid", Name = "_dta_index_PurchaseInvoiceDetail_7_2123154609__K3_K29_K1_K2_4_6_7_10_12_14_16_18_20")]
public partial class PurchaseInvoiceDetail
{
    [Key]
    [Column("PurchaseInvoiceDetailUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceDetailUid { get; set; }

    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

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

    [InverseProperty("PurchaseInvoiceDetailU")]
    public virtual ICollection<PurchaseInvoiceDetailConsignment> PurchaseInvoiceDetailConsignments { get; set; } = new List<PurchaseInvoiceDetailConsignment>();

    [ForeignKey("PurchaseInvoiceHeaderUid")]
    [InverseProperty("PurchaseInvoiceDetails")]
    public virtual PurchaseInvoiceHeader PurchaseInvoiceHeaderU { get; set; } = null!;
}
