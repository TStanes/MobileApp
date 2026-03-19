using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwVoucherdetail1
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }
}
