using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("UserMaster")]
public partial class UserMaster
{
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LoginName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    public bool IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastLoginDate { get; set; }
}
