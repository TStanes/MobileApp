using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TaxExemptedItemMaster")]
public partial class TaxExemptedItemMaster
{
    [Key]
    [Column("TaxExemptedItemMasterUID")]
    public Guid TaxExemptedItemMasterUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("MRPLessThan_BeforeEffectiveDate")]
    [StringLength(50)]
    [Unicode(false)]
    public string MrplessThanBeforeEffectiveDate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Column("MRPLessThan_AfterEffectiveDate")]
    [StringLength(50)]
    [Unicode(false)]
    public string MrplessThanAfterEffectiveDate { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [ForeignKey("ItemSubGroupUid")]
    [InverseProperty("TaxExemptedItemMasters")]
    public virtual ItemSubGroupM ItemSubGroupU { get; set; } = null!;
}
