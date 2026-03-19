using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwBatch
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MfgDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }
}
