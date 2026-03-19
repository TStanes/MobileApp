using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConGrowersOfficeHierarchy")]
public partial class ConGrowersOfficeHierarchy
{
    [StringLength(150)]
    [Unicode(false)]
    public string Zone { get; set; } = null!;

    [Column("Zone Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ZoneCode { get; set; } = null!;

    [Column("Area Office")]
    [StringLength(150)]
    [Unicode(false)]
    public string AreaOffice { get; set; } = null!;

    [Column("AO Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string AoCode { get; set; } = null!;

    [Column("Territory Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string TerritoryName { get; set; } = null!;

    [Column("TR Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string TrCode { get; set; } = null!;

    [Column("HQ Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string HqName { get; set; } = null!;

    [Column("HQ Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string HqCode { get; set; } = null!;
}
