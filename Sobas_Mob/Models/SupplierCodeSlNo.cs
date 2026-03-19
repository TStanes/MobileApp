using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class SupplierCodeSlNo
{
    [Column("SupplierControlCodeUID")]
    public Guid? SupplierControlCodeUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Letter { get; set; }

    public int? LastNo { get; set; }
}
