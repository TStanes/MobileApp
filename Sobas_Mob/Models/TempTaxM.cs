using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempTaxM")]
public partial class TempTaxM
{
    [Column("TaxUID")]
    public Guid? TaxUid { get; set; }

    public Guid? DivisionUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("itemuid")]
    public Guid Itemuid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    public bool FirstSales { get; set; }

    public bool IsActive { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    public bool IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefModifiedDate { get; set; }
}
