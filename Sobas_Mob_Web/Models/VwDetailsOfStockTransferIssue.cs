using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDetailsOfStockTransferIssue
{
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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Value { get; set; }

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
}
