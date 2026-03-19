using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemRate")]
[Index("CreatedDate", Name = "IX_CreatedDate")]
[Index("ItemRateHeaderUid", Name = "IX_ItemRate_ItemRateHeaderUID")]
[Index("ModifiedDate", Name = "IX_ItemRate_ModifiedDate_Includes")]
[Index("ItemUid", "IsActive", Name = "NonClusteredIndex-20170405-180156")]
[Index("IsActive", "ItemUid", Name = "_dta_index_ItemRate_7_935674381__K5_K3_1_2_4_6_7_8_9")]
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
