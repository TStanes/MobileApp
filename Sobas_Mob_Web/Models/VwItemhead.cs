using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwItemhead
{
    [Column("ICode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Icode { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string? ItemHead { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? HeadItemDesc { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("HeadItemUID")]
    public Guid? HeadItemUid { get; set; }
}
