using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwSelectAreaSomappingForCurrentDate
{
    [Column("AreaSOUID")]
    public Guid AreaSouid { get; set; }

    [Column("AreaSOItemGroupUID")]
    public Guid? AreaSoitemGroupUid { get; set; }

    [Column("AreaUID")]
    public Guid AreaUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid? DivisionPrincipleUid { get; set; }

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Socode { get; set; } = null!;

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string Soname { get; set; } = null!;

    [Column("empcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Empcode { get; set; } = null!;

    [Column("SOShortName")]
    [StringLength(50)]
    [Unicode(false)]
    public string SoshortName { get; set; } = null!;
}
