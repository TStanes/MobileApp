using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DiscountTypeM")]
public partial class DiscountTypeM
{
    [Key]
    [Column("DiscountTypeUID")]
    public Guid DiscountTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DiscountTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DiscountTypeDesc { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("DiscountTypeU")]
    public virtual ICollection<DiscountM> DiscountMs { get; set; } = new List<DiscountM>();
}
