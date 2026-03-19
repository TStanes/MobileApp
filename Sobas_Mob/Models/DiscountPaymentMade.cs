using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DiscountPaymentMade")]
public partial class DiscountPaymentMade
{
    [Key]
    [Column("DiscountPaymentMadeUID")]
    public Guid DiscountPaymentMadeUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal FromDays { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal ToDays { get; set; }

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
    [InverseProperty("DiscountPaymentMades")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
