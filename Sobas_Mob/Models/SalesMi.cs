using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalesMIS")]
public partial class SalesMi
{
    [Column("branchstatecode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Branchstatecode { get; set; }

    [Column("branchstatedesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Branchstatedesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    public int? Mon { get; set; }

    public int? Yr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Finyear { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Soname { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? SalesValue { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemSegmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSegmentDesc { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string ItemGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemgroupDesc { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSubGroupDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string AreaDesc { get; set; } = null!;

    [Column("partycode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [Column("partyname")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("itemdesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Itemdesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? DateofJoining { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CurrentSoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CurrentSoName { get; set; }
}
