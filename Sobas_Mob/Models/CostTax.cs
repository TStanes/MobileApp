using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("CostTax")]
public partial class CostTax
{
    [StringLength(7)]
    public string ItemCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    public bool TaxStatus { get; set; }
}
