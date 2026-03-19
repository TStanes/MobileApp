using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwItemmaster
{
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? OldItemCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    public bool IsActive { get; set; }
}
