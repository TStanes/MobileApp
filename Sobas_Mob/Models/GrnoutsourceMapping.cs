using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("GRNOutsourceMapping")]
public partial class GrnoutsourceMapping
{
    [Key]
    [Column("GRNOutsourceMappingUID")]
    public Guid GrnoutsourceMappingUid { get; set; }

    [Column("GRNListUID", TypeName = "decimal(18, 0)")]
    public decimal GrnlistUid { get; set; }

    [Column("OSListUID", TypeName = "decimal(18, 0)")]
    public decimal OslistUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdjQuantity { get; set; }

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

    [ForeignKey("GrnlistUid")]
    [InverseProperty("GrnoutsourceMappingGrnlistUs")]
    public virtual InventoryTransList GrnlistU { get; set; } = null!;

    [ForeignKey("OslistUid")]
    [InverseProperty("GrnoutsourceMappingOslistUs")]
    public virtual InventoryTransList OslistU { get; set; } = null!;
}
