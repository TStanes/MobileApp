using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TaxM")]
[Index("StateUid", Name = "IX_TaxM_StateUID_Includes")]
public partial class TaxM
{
    [Key]
    [Column("TaxUID")]
    public Guid TaxUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    public bool FirstSales { get; set; }

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

    public bool? IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifiedDate { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("TaxMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("ItemGroupUid")]
    [InverseProperty("TaxMs")]
    public virtual ItemGroupM ItemGroupU { get; set; } = null!;

    [ForeignKey("ItemSubGroupUid")]
    [InverseProperty("TaxMs")]
    public virtual ItemSubGroupM? ItemSubGroupU { get; set; }

    [ForeignKey("ItemUid")]
    [InverseProperty("TaxMs")]
    public virtual ItemM? ItemU { get; set; }

    [ForeignKey("StateUid")]
    [InverseProperty("TaxMs")]
    public virtual StateM1 StateU { get; set; } = null!;

    [InverseProperty("TaxU")]
    public virtual ICollection<TaxMdetail> TaxMdetails { get; set; } = new List<TaxMdetail>();
}
