using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchTransferReceipt")]
[Index("InventoryTransUid", Name = "IX_InventoryTrans")]
[Index("ReceivingBranchUid", Name = "IX_RecBrUID")]
public partial class BranchTransferReceipt
{
    [Key]
    [Column("BranchTransferReceiptGUID")]
    public Guid BranchTransferReceiptGuid { get; set; }

    [Column("IssueBranchUID")]
    public Guid IssueBranchUid { get; set; }

    [Column("ReceivingBranchUID")]
    public Guid ReceivingBranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceiveQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid ItemStatusUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal NoOfCases { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool UpdateFlg { get; set; }

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

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

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

    [Column("EDHrEduCessPer", TypeName = "decimal(18, 3)")]
    public decimal? EdhrEduCessPer { get; set; }

    [Column("EDHrEduCessAmt", TypeName = "decimal(18, 3)")]
    public decimal? EdhrEduCessAmt { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    [Column("SGSTUID")]
    public Guid? Sgstuid { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTUID")]
    public Guid? Cgstuid { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTUID")]
    public Guid? Igstuid { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }
}
