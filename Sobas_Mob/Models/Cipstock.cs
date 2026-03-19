using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("cipstock")]
public partial class Cipstock
{
    [Column("branchstatecode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Branchstatecode { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("brnam")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brnam { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("branchuid")]
    public Guid? Branchuid { get; set; }

    [Column("itemuid")]
    public Guid Itemuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNum { get; set; }

    [Column("BAL", TypeName = "decimal(38, 5)")]
    public decimal? Bal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Idesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Iseg { get; set; } = null!;

    [Column("SEGNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Segnam { get; set; } = null!;

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal? Mrp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MfgDate { get; set; }

    public int? StockAge { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemGroupDesc { get; set; } = null!;

    [Column("divisioncode")]
    [StringLength(10)]
    [Unicode(false)]
    public string Divisioncode { get; set; } = null!;

    [Column("divisiondesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Divisiondesc { get; set; } = null!;

    [Column("mvg")]
    public int Mvg { get; set; }
}
