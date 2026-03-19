using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GSt1920SalesData")]
public partial class Gst1920SalesDatum
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

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Soname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemHead { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? HeadItemDesc { get; set; }

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

    [Column("itemcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Itemcode { get; set; } = null!;

    [Column("itemdesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Itemdesc { get; set; } = null!;

    [Column("SGST", TypeName = "decimal(38, 3)")]
    public decimal? Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(38, 3)")]
    public decimal? Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(38, 3)")]
    public decimal? Igst { get; set; }
}
