using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchPOReceived")]
public partial class BranchPoreceived
{
    [Key]
    [Column("BranchPOReceivedUID")]
    public Guid BranchPoreceivedUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("ReceivingBranchUID")]
    public Guid ReceivingBranchUid { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pono { get; set; } = null!;

    [Column("PODate", TypeName = "datetime")]
    public DateTime Podate { get; set; }

    [Column("RANo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Rano { get; set; } = null!;

    [Column("RADate", TypeName = "datetime")]
    public DateTime Radate { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal ReceivedQty { get; set; }

    public bool TransferFlag { get; set; }

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
}
