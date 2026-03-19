using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwFinancialYearM
{
    [StringLength(4)]
    [Unicode(false)]
    public string CurrentYear { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDate { get; set; }
}
