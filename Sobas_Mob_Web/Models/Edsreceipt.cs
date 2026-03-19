using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("EDSReceipts")]
public partial class Edsreceipt
{
    [StringLength(20)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("HeaderID")]
    [StringLength(20)]
    public string? HeaderId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("RowID")]
    [StringLength(20)]
    public string? RowId { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("Item_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Quantity { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Batch { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Rate { get; set; }

    public int? Level { get; set; }

    [Column("IsMF")]
    public int IsMf { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Category { get; set; }

    public int? ReceiptTypeOrder { get; set; }
}
