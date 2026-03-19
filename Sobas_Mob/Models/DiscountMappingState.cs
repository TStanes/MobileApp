using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DiscountMappingState")]
public partial class DiscountMappingState
{
    [Key]
    [Column("DiscountMappingStateUID")]
    public Guid DiscountMappingStateUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

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
    [InverseProperty("DiscountMappingStates")]
    public virtual DiscountM DiscountU { get; set; } = null!;

    [ForeignKey("StateUid")]
    [InverseProperty("DiscountMappingStates")]
    public virtual StateM1 StateU { get; set; } = null!;
}
