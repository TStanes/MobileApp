using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("LastTBProcessed")]
public partial class LastTbprocessed
{
    [Column(TypeName = "datetime")]
    public DateTime? LastDate { get; set; }
}
