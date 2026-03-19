using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("HSNData")]
public partial class Hsndatum
{
    [Key]
    public Guid Itemuid { get; set; }

    [Column("HSN")]
    [StringLength(10)]
    public string? Hsn { get; set; }

    [StringLength(14)]
    public string? Itemcode { get; set; }
}
