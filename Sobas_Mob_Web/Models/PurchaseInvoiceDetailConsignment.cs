using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PurchaseInvoiceDetailConsignment")]
public partial class PurchaseInvoiceDetailConsignment
{
    [Key]
    [Column("PurchaseInvoiceDetailConsignmentUID")]
    public Guid PurchaseInvoiceDetailConsignmentUid { get; set; }

    [Column("PurchaseInvoiceDetailUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceDetailUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

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

    [ForeignKey("PurchaseInvoiceDetailUid")]
    [InverseProperty("PurchaseInvoiceDetailConsignments")]
    public virtual PurchaseInvoiceDetail PurchaseInvoiceDetailU { get; set; } = null!;
}
