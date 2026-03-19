using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class BatchDetail
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Itemcode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    [Column("MFGDt")]
    [StringLength(11)]
    [Unicode(false)]
    public string? Mfgdt { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? ExpDt { get; set; }

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? Stock { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }
}
