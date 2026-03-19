using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class TrailBalance
{
    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? DebitAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? CreditAmt { get; set; }
}
