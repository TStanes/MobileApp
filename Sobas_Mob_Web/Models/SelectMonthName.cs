using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class SelectMonthName
{
    [StringLength(2)]
    [Unicode(false)]
    public string MonthNo { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string MonthName { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string QuarterNo { get; set; } = null!;
}
