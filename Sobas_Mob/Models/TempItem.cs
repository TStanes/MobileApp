using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempItem")]
public partial class TempItem
{
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;
}
