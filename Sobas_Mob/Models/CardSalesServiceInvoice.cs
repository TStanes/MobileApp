using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CardSalesServiceInvoice")]
public partial class CardSalesServiceInvoice
{
    [Key]
    [Column("CardSalesServiceInvoiceUID")]
    public Guid CardSalesServiceInvoiceUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string InvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CardNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CardName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ServiceCharges { get; set; }

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

    [ForeignKey("InventoryTransUid")]
    [InverseProperty("CardSalesServiceInvoices")]
    public virtual InventoryTran InventoryTransU { get; set; } = null!;
}
