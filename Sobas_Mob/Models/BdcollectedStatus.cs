using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BDCollectedStatus")]
public partial class BdcollectedStatus
{
    [Column("BDCollectedUID")]
    public Guid BdcollectedUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("BDAmount", TypeName = "decimal(18, 3)")]
    public decimal? Bdamount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CollectedAmount { get; set; }

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
