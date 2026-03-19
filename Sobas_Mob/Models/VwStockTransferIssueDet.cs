using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwStockTransferIssueDet
{
    [StringLength(50)]
    [Unicode(false)]
    public string SendingBranchCode { get; set; } = null!;

    [Column("Sending Branch")]
    [StringLength(150)]
    [Unicode(false)]
    public string SendingBranch { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Qty { get; set; }

    public int NoOfCases { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReceivingBranchCode { get; set; } = null!;

    [Column("Receiving Branch")]
    [StringLength(150)]
    [Unicode(false)]
    public string ReceivingBranch { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GovtFormNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? GovtFormDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string RecDocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RecDocDate { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RecBrGstNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SendingBrGstNo { get; set; }

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

    [Column("UOMDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Uomdesc { get; set; } = null!;

    public bool Interstate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }
}
