using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("ServerDateTimeValidation")]
public partial class ServerDateTimeValidation
{
    [Column(TypeName = "datetime")]
    public DateTime ServerLastSyncDate { get; set; }
}
