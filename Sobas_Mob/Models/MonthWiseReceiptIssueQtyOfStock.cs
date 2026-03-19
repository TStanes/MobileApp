using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class MonthWiseReceiptIssueQtyOfStock
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("MONTH")]
    public int? Month { get; set; }

    public int? Year { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ReceiptQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? IssueQty { get; set; }
}
