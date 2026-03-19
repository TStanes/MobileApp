using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TblAccount")]
public partial class TblAccount
{
    [Column("UID")]
    public Guid? Uid { get; set; }

    [StringLength(50)]
    public string? DocNo { get; set; }

    [StringLength(50)]
    public string? AccountCode { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? CreditAmt { get; set; }
}
