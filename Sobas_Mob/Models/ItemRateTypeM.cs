using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemRateTypeM")]
public partial class ItemRateTypeM
{
    [Key]
    [Column("ItemRateTypeUID")]
    public Guid ItemRateTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RateTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RateTypeDesc { get; set; } = null!;

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
}
