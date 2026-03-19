using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountQtyLift")]
public partial class DiscountQtyLift
{
    [Key]
    [Column("DiscountQtyLiftUID")]
    public Guid DiscountQtyLiftUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal FromQty { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal ToQty { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Percentage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifieddate { get; set; }

    [ForeignKey("DiscountUid")]
    [InverseProperty("DiscountQtyLifts")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
