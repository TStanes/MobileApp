using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class PackingM
{
    [StringLength(150)]
    [Unicode(false)]
    public string Packing { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CodeExtn { get; set; } = null!;
}
