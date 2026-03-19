using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Temp_IBTAlreadyInsertedVoucher_Delete")]
public partial class TempIbtalreadyInsertedVoucherDelete
{
    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }
}
