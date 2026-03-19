using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("VOUCHERCHECKTEMPFORSSI")]
public partial class Voucherchecktempforssi
{
    [Column("VOUCHERHEADERUID")]
    public Guid Voucherheaderuid { get; set; }
}
