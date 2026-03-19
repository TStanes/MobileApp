using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("voucherentryspeed")]
public partial class Voucherentryspeed
{
    public int? Vouchers { get; set; }

    [Column("onTime", TypeName = "datetime")]
    public DateTime OnTime { get; set; }
}
