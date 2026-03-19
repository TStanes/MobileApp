using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TaxboxMHeader")]
public partial class TaxboxMheader
{
    [Column("TaxUID")]
    public Guid? TaxUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("StateUID")]
    [StringLength(36)]
    [Unicode(false)]
    public string StateUid { get; set; } = null!;

    [Column("ItemSubGroupUID")]
    public int? ItemSubGroupUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [StringLength(23)]
    [Unicode(false)]
    public string EffectiveFrom { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string FirstSales { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string IsActive { get; set; } = null!;

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

    [StringLength(1)]
    [Unicode(false)]
    public string IsProcessed { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefModifiedDate { get; set; }
}
