using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ActiveAreaSoMappingAppDatum
{
    [Column("HQ Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? HqCode { get; set; }

    [Column("HQ Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? HqName { get; set; }

    [Column("Segment Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SegmentName { get; set; }

    [Column("Segment code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SegmentCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }

    [Column("Area Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AreaCode { get; set; }

    [Column("Area Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? AreaName { get; set; }

    [Column("State Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [Column("State Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? StateName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SoCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SoName { get; set; } = null!;

    [Column("Emp Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmpCode { get; set; } = null!;
}
