using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProfitandLossHierachy")]
public partial class ProfitandLossHierachy
{
    [StringLength(50)]
    [Unicode(false)]
    public string? ParentAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? ParentAccountDescription { get; set; }

    public int? SortOrder { get; set; }
}
