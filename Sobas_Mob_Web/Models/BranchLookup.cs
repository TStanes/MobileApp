using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class BranchLookup
{
    [Column("STATE_UID")]
    public Guid StateUid { get; set; }

    [Column("STATE_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("BRANCH_UID")]
    public Guid BranchUid { get; set; }

    [Column("BRANCH_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("msrepl_tran_version")]
    public Guid? MsreplTranVersion { get; set; }

    [Column("DIV")]
    [StringLength(10)]
    [Unicode(false)]
    public string Div { get; set; } = null!;
}
