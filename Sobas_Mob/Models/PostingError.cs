using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("PostingError")]
public partial class PostingError
{
    [Unicode(false)]
    public string? ErrorNumber { get; set; }

    [Unicode(false)]
    public string? ErrorMessage { get; set; }

    [Column("fromid")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fromid { get; set; }

    [Column("inventorytranUID", TypeName = "decimal(18, 0)")]
    public decimal? InventorytranUid { get; set; }
}
