using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("pdfqry")]
public partial class Pdfqry
{
    [Column("quid")]
    [StringLength(255)]
    public string? Quid { get; set; }

    [Column("newqryname")]
    [StringLength(255)]
    public string? Newqryname { get; set; }
}
