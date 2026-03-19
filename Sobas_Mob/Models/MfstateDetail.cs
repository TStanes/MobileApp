using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class MfstateDetail
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("CompositionStateUID")]
    public Guid? CompositionStateUid { get; set; }
}
