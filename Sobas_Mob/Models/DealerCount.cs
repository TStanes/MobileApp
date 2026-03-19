using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DealerCount")]
public partial class DealerCount
{
    [StringLength(50)]
    [Unicode(false)]
    public string? SoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column("PArtycode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("branchstatecode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Branchstatecode { get; set; }

    [Column("branchstatedesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Branchstatedesc { get; set; }

    [Column("BRanchCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;
}
