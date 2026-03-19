using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Einv_OwnID")]
public partial class EinvOwnId
{
    [Column("canAccess")]
    public bool CanAccess { get; set; }

    [Column("id")]
    [StringLength(255)]
    public string? Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("level")]
    [StringLength(255)]
    public string? Level { get; set; }

    [Column("product")]
    [StringLength(255)]
    public string? Product { get; set; }

    [Column("parentOrgUnitId")]
    [StringLength(255)]
    public string? ParentOrgUnitId { get; set; }
}
