using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountValueLift")]
public partial class DiscountValueLift
{
    [Key]
    [Column("DiscountValueLiftUID")]
    public Guid DiscountValueLiftUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal FromValue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal ToValue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Percentage { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
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
    [InverseProperty("DiscountValueLifts")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
