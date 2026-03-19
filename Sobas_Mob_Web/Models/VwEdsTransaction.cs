using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwEdsTransaction
{
    [StringLength(15)]
    [Unicode(false)]
    public string TransType { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column("HeaderID", TypeName = "decimal(18, 0)")]
    public decimal HeaderId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("RowID", TypeName = "decimal(18, 0)")]
    public decimal RowId { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("Item_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Quantity { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Batch { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    public int? Level { get; set; }

    [Column("IsMF")]
    public bool? IsMf { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    public int? ReceiptTypeOrder { get; set; }
}
