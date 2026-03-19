using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConGrowerUpload")]
public partial class ConGrowerUpload
{
    [StringLength(15)]
    [Unicode(false)]
    public string? EntityNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EntityName { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Pincode { get; set; }

    [Column("TaxID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TaxId { get; set; }

    public bool? IsActive { get; set; }
}
