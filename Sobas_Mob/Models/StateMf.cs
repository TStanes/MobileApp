using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class StateMf
{
    [StringLength(10)]
    [Unicode(false)]
    public string TranType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("st")]
    [StringLength(50)]
    [Unicode(false)]
    public string? St { get; set; }

    [Column("stdesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Stdesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Carrier { get; set; } = null!;

    [Column("rate", TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("an", TypeName = "decimal(18, 0)")]
    public decimal? An { get; set; }

    [Column("branchcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Branchcode { get; set; }
}
