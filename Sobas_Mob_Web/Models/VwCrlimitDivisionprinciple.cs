using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwCrlimitDivisionprinciple
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyAcHead { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyTypeDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;
}
