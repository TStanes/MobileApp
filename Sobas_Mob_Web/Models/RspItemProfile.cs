using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class RspItemProfile
{
    [StringLength(13)]
    [Unicode(false)]
    public string Itype { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Icode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Idesc { get; set; } = null!;
}
