using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwInventoryService
{
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

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

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BranchType { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchStateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchStateDesc { get; set; } = null!;

    [Column("ReceivingBranchUID")]
    public Guid? ReceivingBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RecBranchName { get; set; }

    [Column("RecStateUID")]
    public Guid? RecStateUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RecBranchType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecStateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RecStateDesc { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string UsedFor { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("PartyTypeUID")]
    public Guid? PartyTypeUid { get; set; }

    [Column("PartyBranchUID")]
    public Guid? PartyBranchUid { get; set; }

    [Column("PartyAreaUID")]
    public Guid? PartyAreaUid { get; set; }

    [Column("PartyDivisionUID")]
    public Guid? PartyDivisionUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyInitials { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [Column("DealerTypeUID")]
    public Guid? DealerTypeUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid? DealerCategoryUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PartyAcHead { get; set; }

    [Column("PartyGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyGlcode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyCity { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyPinCode { get; set; }

    [Column("PartyStateUID")]
    public Guid? PartyStateUid { get; set; }

    [Column("PartyCountryUID")]
    public Guid? PartyCountryUid { get; set; }

    public bool? PartyVatCovered { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyContactPersonPhoneNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyTypeDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyBranchName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyAreaCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyAreaDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DealerCategoryCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DealerCategoryDesc { get; set; }

    [Column("PartyAccountUID")]
    public Guid? PartyAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? PartyAccountDescription { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    public bool Interstate { get; set; }

    [Column("SecondarySupplierUID")]
    public Guid? SecondarySupplierUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SecSupplierCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SecSupplierName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SecAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SecAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SecAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SecAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SecCity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SecPinCode { get; set; }

    [Column("SecStateUID")]
    public Guid? SecStateUid { get; set; }

    [Column("FrieghtPaymentTypeUID")]
    public Guid? FrieghtPaymentTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FrieghtPaymentCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FrieghtPaymentType { get; set; }

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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalServiceTax { get; set; }

    [Column("TotalServiceCESS", TypeName = "decimal(18, 3)")]
    public decimal TotalServiceCess { get; set; }

    [Column("TotalVAT", TypeName = "decimal(18, 3)")]
    public decimal TotalVat { get; set; }

    [Column("TotalVATCESS", TypeName = "decimal(18, 3)")]
    public decimal TotalVatcess { get; set; }

    [Column("TotalServiceHEDUCess", TypeName = "decimal(18, 3)")]
    public decimal TotalServiceHeducess { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

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

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Soname { get; set; }

    [Column("SOShortName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SoshortName { get; set; }

    [Column("VATDebitNoteNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VatdebitNoteNo { get; set; }

    [Column("VATDebitNoteDate", TypeName = "datetime")]
    public DateTime? VatdebitNoteDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [Column("CompositionStateUID")]
    public Guid? CompositionStateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CompStateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CompStateDesc { get; set; }

    public bool? PrintFlag { get; set; }

    public bool TransferFlag { get; set; }

    public bool IsActive { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal LineNumber { get; set; }

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

    [Column("UOMUID")]
    public Guid Uomuid { get; set; }

    public bool IsFillMaterial { get; set; }

    [Column("ABCClass")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Abcclass { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? NoOfPack { get; set; }

    [Column("ROL", TypeName = "decimal(10, 2)")]
    public decimal? Rol { get; set; }

    [Column("ROQ", TypeName = "decimal(10, 2)")]
    public decimal? Roq { get; set; }

    [Column("EOQ", TypeName = "decimal(10, 2)")]
    public decimal? Eoq { get; set; }

    [Column("ChemicalUID")]
    public Guid? ChemicalUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    [StringLength(20)]
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

    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? PoheaderUid { get; set; }

    [Column("POIndentUID", TypeName = "decimal(18, 0)")]
    public decimal? PoindentUid { get; set; }

    [Column("POQty", TypeName = "decimal(18, 3)")]
    public decimal? Poqty { get; set; }

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
    public DateTime? Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid? ItemStatusUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemStatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemStatusDescription { get; set; }

    public int? NoOfCases { get; set; }

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

    [Column("ServiceUID")]
    public Guid? ServiceUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ServicePer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ServiceAmt { get; set; }

    [Column("ServiceCessUID")]
    public Guid? ServiceCessUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ServiceCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ServiceCessAmt { get; set; }

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

    [Column("ServiceHEduCessUID")]
    public Guid? ServiceHeduCessUid { get; set; }

    [Column("ServiceHEduCessPer", TypeName = "decimal(18, 2)")]
    public decimal? ServiceHeduCessPer { get; set; }

    [Column("ServiceHEduCessAmt", TypeName = "decimal(18, 3)")]
    public decimal? ServiceHeduCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("RATransLineUID", TypeName = "decimal(18, 0)")]
    public decimal? RatransLineUid { get; set; }

    [Column("SalesReturnInvTransUID", TypeName = "decimal(18, 0)")]
    public decimal? SalesReturnInvTransUid { get; set; }

    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? SoheaderUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToPartyName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BillToCity { get; set; }

    [Column("BillToStateUID")]
    public Guid? BillToStateUid { get; set; }

    [Column("BillToCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BillToCst { get; set; }

    [Column("BillToLST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BillToLst { get; set; }

    [Column("BillToTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BillToTinno { get; set; }

    [Column("BillToDealerCategoryUID")]
    public Guid? BillToDealerCategoryUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToPartyName { get; set; }

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

    [Column("ShipToStateUID")]
    public Guid? ShipToStateUid { get; set; }

    [Column("ShipToCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToCst { get; set; }

    [Column("ShipToLST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToLst { get; set; }

    [Column("ShipToTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToTinno { get; set; }

    [Column("ShipToDealerCategoryUID")]
    public Guid? ShipToDealerCategoryUid { get; set; }

    [Column("ParentBranchUID")]
    public Guid? ParentBranchUid { get; set; }

    [Column("SGST", TypeName = "decimal(18, 3)")]
    public decimal Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(18, 3)")]
    public decimal Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 3)")]
    public decimal Igst { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [Column("BranchGSTNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BranchGstno { get; set; }

    [Column("ParentBranchGSTNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ParentBranchGstno { get; set; }

    [Column("PartyGSTNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartyGstno { get; set; }
}
