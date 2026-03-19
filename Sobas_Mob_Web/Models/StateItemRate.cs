using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StateItemRate")]
public partial class StateItemRate
{
    [Key]
    [Column("StateItemRateUID")]
    public Guid StateItemRateUid { get; set; }

    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

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
    public DateTime? RefCreateddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifieddate { get; set; }

    [ForeignKey("ItemRateHeaderUid")]
    [InverseProperty("StateItemRates")]
    public virtual ItemRateHeader ItemRateHeaderU { get; set; } = null!;

    [ForeignKey("StateUid")]
    [InverseProperty("StateItemRates")]
    public virtual StateM1 StateU { get; set; } = null!;
}
