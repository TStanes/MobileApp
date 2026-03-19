using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DiscountMappingArea")]
public partial class DiscountMappingArea
{
    [Key]
    [Column("DiscountMappingAreaUID")]
    public Guid DiscountMappingAreaUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("AreaUID")]
    public Guid AreaUid { get; set; }

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
    [InverseProperty("DiscountMappingAreas")]
    public virtual DiscountM DiscountU { get; set; } = null!;
}
