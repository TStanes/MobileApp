using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("UserRightsWebApplication")]
public partial class UserRightsWebApplication
{
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ObjectName { get; set; } = null!;

    public bool? IsAllowed { get; set; }
}
