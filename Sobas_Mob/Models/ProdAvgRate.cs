using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProdAvgRate")]
public partial class ProdAvgRate
{
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("AVGRate", TypeName = "decimal(18, 3)")]
    public decimal? Avgrate { get; set; }
}
