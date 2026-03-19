using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class BrMasSt
{
    [Column("BR_UID")]
    public Guid BrUid { get; set; }

    [Column("BR_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string BrCode { get; set; } = null!;

    [Column("BR_NAME")]
    [StringLength(150)]
    [Unicode(false)]
    public string BrName { get; set; } = null!;

    [Column("ST_COD")]
    [StringLength(50)]
    [Unicode(false)]
    public string StCod { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Info { get; set; } = null!;
}
