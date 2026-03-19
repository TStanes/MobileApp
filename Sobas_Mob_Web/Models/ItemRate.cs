using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemRate")]
public partial class ItemRate
{
    [Key]
    [Column("ItemRateUID")]
    public Guid ItemRateUid { get; set; }

    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rate { get; set; }

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
    public DateTime? RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifiedDate { get; set; }

    [ForeignKey("ItemRateHeaderUid")]
    [InverseProperty("ItemRates")]
    public virtual ItemRateHeader ItemRateHeaderU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemRates")]
    public virtual ItemM ItemU { get; set; } = null!;
}
