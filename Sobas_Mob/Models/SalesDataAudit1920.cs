using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalesDataAudit1920")]
public partial class SalesDataAudit1920
{
    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InvNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Nature { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;
}
