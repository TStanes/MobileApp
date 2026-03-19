using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProductionItemRanking")]
public partial class ProductionItemRanking
{
    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    public int? Rank { get; set; }
}
