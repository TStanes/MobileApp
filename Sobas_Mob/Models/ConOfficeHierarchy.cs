using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConOfficeHierarchy")]
public partial class ConOfficeHierarchy
{
    [StringLength(150)]
    [Unicode(false)]
    public string? Zone { get; set; }

    [Column("Zone Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ZoneCode { get; set; }

    [Column("Area Office")]
    [StringLength(150)]
    [Unicode(false)]
    public string? AreaOffice { get; set; }

    [Column("Ao Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AoCode { get; set; }

    [Column("Territory Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? TerritoryName { get; set; }

    [Column("TR Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? TrCode { get; set; }

    [Column("HQ Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? HqName { get; set; }

    [Column("HQ Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? HqCode { get; set; }
}
