using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ConGrowersFarmer
{
    [StringLength(15)]
    [Unicode(false)]
    public string? EntityNumber { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string EntityName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("HQCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Hqcode { get; set; }

    [Column("HQName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Hqname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [Column("TaxID")]
    [StringLength(1)]
    [Unicode(false)]
    public string TaxId { get; set; } = null!;

    public bool IsActive { get; set; }
}
