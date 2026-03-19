using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwBceSum1
{
    [StringLength(50)]
    [Unicode(false)]
    public string Brcode { get; set; } = null!;

    [Column("br_name")]
    [StringLength(150)]
    [Unicode(false)]
    public string BrName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string StmtNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StmtDt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OpnCash { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Totexp { get; set; }

    [Column("CCU", TypeName = "decimal(18, 3)")]
    public decimal Ccu { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrImpAmt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrAddImp { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BrPostImp { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal BankBal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CashBal { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Reimpend { get; set; }

    public int? D1000 { get; set; }

    public int? D500 { get; set; }

    public int? D100 { get; set; }

    public int? D50 { get; set; }

    public int? D20 { get; set; }

    public int? D10 { get; set; }

    public int? D5 { get; set; }

    public int? D2 { get; set; }

    public int? D1 { get; set; }

    public int? Dcoins { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Reimpendst { get; set; } = null!;

    [Column("BceReimbUID")]
    public Guid BceReimbUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }
}
