using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("StatewiseVATClaim")]
public partial class StatewiseVatclaim
{
    [Column("StatewiseVATClaimUID")]
    public Guid StatewiseVatclaimUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    public int Days { get; set; }

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
