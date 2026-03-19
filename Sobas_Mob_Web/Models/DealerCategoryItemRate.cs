using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DealerCategoryItemRate")]
public partial class DealerCategoryItemRate
{
    [Key]
    [Column("DealerCategoryItemRateUID")]
    public Guid DealerCategoryItemRateUid { get; set; }

    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid DealerCategoryUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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

    [ForeignKey("DealerCategoryUid")]
    [InverseProperty("DealerCategoryItemRates")]
    public virtual DealerCategoryM DealerCategoryU { get; set; } = null!;

    [ForeignKey("ItemRateHeaderUid")]
    [InverseProperty("DealerCategoryItemRates")]
    public virtual ItemRateHeader ItemRateHeaderU { get; set; } = null!;
}
