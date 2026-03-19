using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class Vasummary
{
    [MaxLength(30)]
    public byte[]? Size { get; set; }

    public int? Reserved { get; set; }

    public int? Free { get; set; }
}
