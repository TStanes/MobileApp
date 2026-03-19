using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwProdSlip
{
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("BRNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brnam { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("RTQTY", TypeName = "decimal(18, 5)")]
    public decimal Rtqty { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Trantype { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal BillQty { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Carrier { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Expr1 { get; set; } = null!;

    public bool? DelRecord { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string IssItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string IssItemDesc { get; set; } = null!;

    [Column("IssRTQTY", TypeName = "decimal(18, 5)")]
    public decimal IssRtqty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IssDocNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InitialMoisture { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FinalMoisture { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DryingLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessRejQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessChaffQty { get; set; }

    [Column("ProcessIVLQty", TypeName = "decimal(18, 3)")]
    public decimal ProcessIvlqty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessSandQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessStoneQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ProcessPerLot { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ProcessQtyLot { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal MoistureLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RoastedLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PackingLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductionLoss { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GovtLotNo { get; set; } = null!;
}
