using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VoucherDetailFreightExtn")]
public partial class VoucherDetailFreightExtn
{
    [Key]
    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Origin { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Destination { get; set; }

    [Column("KMs")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Kms { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
