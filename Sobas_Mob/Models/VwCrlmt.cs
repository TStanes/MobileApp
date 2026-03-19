using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwCrlmt
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

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CreditDays { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CreditLimit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;
}
