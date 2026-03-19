using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FreeItemQty")]
public partial class FreeItemQty
{
    [Key]
    [Column("FreeItemQtyUID")]
    public Guid FreeItemQtyUid { get; set; }

    [Column("FreeItemMUID")]
    public Guid FreeItemMuid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FromQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ToQty { get; set; }

    [Column("FreeItemUID")]
    public Guid FreeItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FreeQty { get; set; }

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

    [ForeignKey("FreeItemMuid")]
    [InverseProperty("FreeItemQties")]
    public virtual FreeItemM FreeItemMu { get; set; } = null!;

    [ForeignKey("FreeItemUid")]
    [InverseProperty("FreeItemQties")]
    public virtual ItemM FreeItemU { get; set; } = null!;
}
