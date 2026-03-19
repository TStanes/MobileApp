using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("ProcessInformation")]
public partial class ProcessInformation
{
    public int SlNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastProcessedOn { get; set; }

    [StringLength(500)]
    public string MonthProcessed { get; set; } = null!;
}
