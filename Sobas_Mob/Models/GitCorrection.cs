using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GIT_Correction")]
public partial class GitCorrection
{
    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [Column("OrginalAccountUID")]
    public Guid OrginalAccountUid { get; set; }

    [Column("NewAccountUID")]
    public Guid? NewAccountUid { get; set; }
}
