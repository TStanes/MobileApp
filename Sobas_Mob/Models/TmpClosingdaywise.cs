using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TmpClosingdaywise")]
public partial class TmpClosingdaywise
{
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RunningStock { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? MovingAvg { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [Column("qty", TypeName = "decimal(20, 3)")]
    public decimal? Qty { get; set; }
}
