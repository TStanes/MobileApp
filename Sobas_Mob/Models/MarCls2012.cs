using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MarCls2012")]
public partial class MarCls2012
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Branchcode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Branchname { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Divisioncode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionDesc { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSegmentDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [Column("DOCdate", TypeName = "datetime")]
    public DateTime Docdate { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? ClosingStock { get; set; }
}
