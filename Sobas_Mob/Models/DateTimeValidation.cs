using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DateTimeValidation")]
public partial class DateTimeValidation
{
    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }
}
