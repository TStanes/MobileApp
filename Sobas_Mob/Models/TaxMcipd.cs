using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TaxMCIpd")]
public partial class TaxMcipd
{
    public Guid? Nuid { get; set; }

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

    [StringLength(11)]
    [Unicode(false)]
    public string EffectiveFrom { get; set; } = null!;

    public bool FirstSales { get; set; }

    public bool IsActive { get; set; }

    [Column("createdby")]
    [StringLength(50)]
    [Unicode(false)]
    public string Createdby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Modifiedby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
