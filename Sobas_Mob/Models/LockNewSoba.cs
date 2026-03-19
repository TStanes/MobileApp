using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class LockNewSoba
{
    public bool LockSobas { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LockMessage { get; set; }
}
