using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("QtyAdjInfo")]
public partial class QtyAdjInfo
{
    [Column("Branch_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("Item_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Receipt { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Issue { get; set; }
}
