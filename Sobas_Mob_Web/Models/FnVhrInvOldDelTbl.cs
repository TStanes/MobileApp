using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("FN_Vhr_Inv_Old_Del_Tbl")]
public partial class FnVhrInvOldDelTbl
{
    [Column("divisionprincipleuid")]
    public Guid? Divisionprincipleuid { get; set; }

    [Column("VoucherMatchUID")]
    public Guid VoucherMatchUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal AdjAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? UnAdjAmt { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string DrCrType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    public int? DueDays { get; set; }

    [Column("0_30days", TypeName = "decimal(38, 3)")]
    public decimal? _030days { get; set; }

    [Column("31_60days", TypeName = "decimal(38, 3)")]
    public decimal? _3160days { get; set; }

    [Column("61_90days", TypeName = "decimal(38, 3)")]
    public decimal? _6190days { get; set; }

    [Column("91_120days", TypeName = "decimal(38, 3)")]
    public decimal? _91120days { get; set; }

    [Column("121_150days", TypeName = "decimal(38, 3)")]
    public decimal? _121150days { get; set; }

    [Column("151_180days", TypeName = "decimal(38, 3)")]
    public decimal? _151180days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Above180days { get; set; }
}
