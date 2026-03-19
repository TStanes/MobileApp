using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwDetailsOfStockTransferReceived
{
    [Column("Receiving Branch Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBranchCode { get; set; } = null!;

    [Column("Receiving Branch")]
    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBranch { get; set; } = null!;

    [Column("RA.NO.")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RaNo { get; set; }

    [Column("RA.DATE", TypeName = "datetime")]
    public DateTime RaDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("EDAmt", TypeName = "decimal(18, 3)")]
    public decimal Edamt { get; set; }

    [Column("EDCessAmt", TypeName = "decimal(18, 3)")]
    public decimal EdcessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal EdHrEduCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column(TypeName = "decimal(21, 3)")]
    public decimal? Value { get; set; }

    [Column("Transport Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TransportName { get; set; }

    [Column("LRNO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Lrno { get; set; }

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SendingBranchCode { get; set; } = null!;

    [Column("Sending Branch")]
    [StringLength(150)]
    [Unicode(false)]
    public string SendingBranch { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [Column("Issue Doc.No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IssueDocNo { get; set; }

    [Column("Issue Doc.Date", TypeName = "datetime")]
    public DateTime IssueDocDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GovtFormNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? GovtFormDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [Column("UOMDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Uomdesc { get; set; }

    public bool IsActive { get; set; }

    [Column("SendingBrGSTNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SendingBrGstno { get; set; }

    [Column("RecBrGSTNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RecBrGstno { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetVal { get; set; }

    [Column("HSNCode")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Hsncode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;
}
