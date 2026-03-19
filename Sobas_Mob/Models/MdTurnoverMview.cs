using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MD_Turnover_MView")]
public partial class MdTurnoverMview
{
    [StringLength(10)]
    public string Stype { get; set; } = null!;

    [StringLength(10)]
    public string Syear { get; set; } = null!;

    [StringLength(2)]
    public string Smonth { get; set; } = null!;

    [StringLength(15)]
    public string SrowDisp { get; set; } = null!;

    [Column("SProductGroup")]
    [StringLength(25)]
    public string SproductGroup { get; set; } = null!;

    [Column("SProductQty")]
    public long SproductQty { get; set; }

    public long SproductValue { get; set; }

    [Column("isActive")]
    public bool IsActive { get; set; }

    [Column("isubgroupcode")]
    [StringLength(15)]
    public string? Isubgroupcode { get; set; }
}
