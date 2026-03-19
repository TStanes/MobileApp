using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemSupplierLink")]
[Index("ItemUid", Name = "IX_ItemSupplierLink_ItemUID")]
public partial class ItemSupplierLink
{
    [Key]
    [Column("ItemSupplierLinkUID")]
    public Guid ItemSupplierLinkUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CreditTerm { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DeliveryMode { get; set; } = null!;

    [Column("H0Description")]
    [StringLength(150)]
    [Unicode(false)]
    public string? H0description { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemSupplierLinks")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("PartyUid")]
    [InverseProperty("ItemSupplierLinks")]
    public virtual PartyM PartyU { get; set; } = null!;
}
