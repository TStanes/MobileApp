using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CrDrNoteInvoiceLink")]
public partial class CrDrNoteInvoiceLink
{
    [Key]
    [Column("CrDrNoteInvoiceLinkUID")]
    public Guid CrDrNoteInvoiceLinkUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string IsDrCr { get; set; } = null!;

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

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

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }
}
