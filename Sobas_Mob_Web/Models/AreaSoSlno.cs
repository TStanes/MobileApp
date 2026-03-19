using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("AreaSoSlno")]
public partial class AreaSoSlno
{
    [StringLength(100)]
    public string TableName { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Letter { get; set; }

    public int LastNo { get; set; }
}
