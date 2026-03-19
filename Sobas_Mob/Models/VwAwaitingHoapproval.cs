using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwAwaitingHoapproval
{
    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ReceivingBranchUID")]
    public Guid? ReceivingBranchUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("PartyShipToUID")]
    public Guid? PartyShipToUid { get; set; }

    public bool? IsFirstSale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalesType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RefNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RefDate { get; set; }

    public int? DueDays { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid? DivisionPrincipleUid { get; set; }

    public bool Interstate { get; set; }

    [Column("SecondarySupplierUID")]
    public Guid? SecondarySupplierUid { get; set; }

    [Column("FrieghtPaymentTypeUID")]
    public Guid? FrieghtPaymentTypeUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtMinus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? HandlingCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Others { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Insurance { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ClaimSettlement { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CarrierNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CarrierName { get; set; }

    [Column("LRNO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Lrno { get; set; }

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [Column("VATFormNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VatformNo { get; set; }

    [Column("VATFormDate", TypeName = "datetime")]
    public DateTime? VatformDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductValue { get; set; }

    [Column("ED", TypeName = "decimal(18, 3)")]
    public decimal Ed { get; set; }

    [Column("CESS", TypeName = "decimal(18, 3)")]
    public decimal Cess { get; set; }

    [Column("VAT", TypeName = "decimal(18, 3)")]
    public decimal Vat { get; set; }

    [Column("VATCESS", TypeName = "decimal(18, 3)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal GrossVal { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Roundoff { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetVal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? RequestReason { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectReason { get; set; }

    [Column("StatusUID")]
    public Guid? StatusUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDt { get; set; }

    [Column("RefInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefInventoryTransUid { get; set; }

    [Column("PreRAUID", TypeName = "decimal(18, 0)")]
    public decimal? PreRauid { get; set; }

    [Column("CForm")]
    public bool? Cform { get; set; }

    [Column("FormHNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FormHno { get; set; }

    [Column("FormFNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FormFno { get; set; }

    [Column("FromFDate", TypeName = "datetime")]
    public DateTime? FromFdate { get; set; }

    [Column("ChqDDNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChqDdno { get; set; }

    [Column("ChqDDDate", TypeName = "datetime")]
    public DateTime? ChqDddate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CardName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CardNo { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? CashReceiptNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CashReceiptDate { get; set; }

    [Column("AreaSOUID")]
    public Guid? AreaSouid { get; set; }

    [Column("VATDebitNoteNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VatdebitNoteNo { get; set; }

    [Column("VATDebitNoteDate", TypeName = "datetime")]
    public DateTime? VatdebitNoteDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    public bool TransferFlag { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal LineNumber { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReceiptReturnQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CarrierShortages { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Moistureqty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetQty { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal? PolineUid { get; set; }

    [Column("PORateUID")]
    public Guid? PorateUid { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SupplierInvoiceRate { get; set; }

    [Column("MRPUID")]
    public Guid? Mrpuid { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("PriceListUID")]
    public Guid? PriceListUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid? ItemStatusUid { get; set; }

    public int NoOfCases { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount4Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4Amt { get; set; }

    [Column("EDUID")]
    public Guid? Eduid { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 2)")]
    public decimal Edper { get; set; }

    [Column("EDAmt", TypeName = "decimal(18, 3)")]
    public decimal Edamt { get; set; }

    [Column("EDCessUID")]
    public Guid? EdcessUid { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 2)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCessAmt", TypeName = "decimal(18, 3)")]
    public decimal EdcessAmt { get; set; }

    [Column("VATUID")]
    public Guid? Vatuid { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 2)")]
    public decimal Vatper { get; set; }

    [Column("VATAmt", TypeName = "decimal(18, 3)")]
    public decimal Vatamt { get; set; }

    [Column("VATCessUID")]
    public Guid? VatcessUid { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 2)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCessAmt", TypeName = "decimal(18, 3)")]
    public decimal VatcessAmt { get; set; }

    [Column("SecondaryCessUID")]
    public Guid? SecondaryCessUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SecondaryCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SecondaryCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("RATransLineUID", TypeName = "decimal(18, 0)")]
    public decimal? RatransLineUid { get; set; }

    [Column("SalesReturnInvTransUID", TypeName = "decimal(18, 0)")]
    public decimal? SalesReturnInvTransUid { get; set; }

    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? SoheaderUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ReceivingBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ReceivingBranchName { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tinno { get; set; }

    [Column("LST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Lst { get; set; }

    [Column("CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cst { get; set; }

    [Column("PANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Panno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ExciseOffice { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseDivision { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseRange { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? WebAddress { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToCity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShipToPinCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToState { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToTelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToFaxNo { get; set; }

    [Column("ShipToTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToTinno { get; set; }

    [Column("ShipToLST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToLst { get; set; }

    [Column("ShipToCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToCst { get; set; }

    [Column("ShipToPANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToPanno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToExciseNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToExciseOffice { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToExciseDivision { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToExciseRange { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToEmail { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("UOMDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Uomdesc { get; set; }
}
