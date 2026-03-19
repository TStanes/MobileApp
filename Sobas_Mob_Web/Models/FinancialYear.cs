using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("FinancialYear")]
public partial class FinancialYear
{
    [Column(TypeName = "datetime")]
    public DateTime From { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime To { get; set; }
}
