using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class EdCharge
{
    [Column("it")]
    [StringLength(50)]
    [Unicode(false)]
    public string It { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [Column("State_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("Sub_group")]
    [StringLength(4)]
    [Unicode(false)]
    public string SubGroup { get; set; } = null!;

    [Column("main")]
    [StringLength(50)]
    [Unicode(false)]
    public string Main { get; set; } = null!;

    [Column("maindesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Maindesc { get; set; } = null!;

    [Column("branch_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("item code")]
    [StringLength(3)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("description")]
    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("qty", TypeName = "decimal(38, 3)")]
    public decimal? Qty { get; set; }

    [Column("rate", TypeName = "decimal(38, 6)")]
    public decimal? Rate { get; set; }

    [Column("cess", TypeName = "decimal(38, 6)")]
    public decimal? Cess { get; set; }

    [Column("EDCHG", TypeName = "decimal(38, 6)")]
    public decimal? Edchg { get; set; }
}
