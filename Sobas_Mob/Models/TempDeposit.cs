using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempDeposit")]
public partial class TempDeposit
{
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DlrDepRtno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DlrDepRtdt { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? DlrDepAmt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RefundNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefundDate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? RefundAmt { get; set; }
}
