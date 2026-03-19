using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("UserRightsWebApplication_Delete")]
public partial class UserRightsWebApplicationDelete
{
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ObjectName { get; set; } = null!;

    public bool? IsAllowed { get; set; }
}
