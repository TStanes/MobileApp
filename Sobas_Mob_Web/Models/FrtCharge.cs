using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class FrtCharge
{
    [Column("category")]
    [StringLength(150)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Column("item_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("itdesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Itdesc { get; set; } = null!;

    [Column("qty", TypeName = "decimal(38, 3)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Frate { get; set; }

    [Column("STate")]
    [StringLength(150)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [Column("State_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("item code")]
    [StringLength(3)]
    [Unicode(false)]
    public string ItemCode1 { get; set; } = null!;

    [Column("description")]
    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("branch_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("FRTVALUE", TypeName = "decimal(38, 3)")]
    public decimal? Frtvalue { get; set; }
}
