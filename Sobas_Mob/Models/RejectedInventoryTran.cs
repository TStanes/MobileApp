using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class RejectedInventoryTran
{
    [Key]
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

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
    public string DocNo { get; set; } = null!;

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

    public bool IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("InventoryTransU")]
    public virtual ICollection<RejectedInventoryTransList> RejectedInventoryTransLists { get; set; } = new List<RejectedInventoryTransList>();
}
