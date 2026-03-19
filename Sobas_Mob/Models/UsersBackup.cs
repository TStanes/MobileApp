using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("UsersBackup")]
public partial class UsersBackup
{
    [Column("UserUID")]
    public Guid UserUid { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string UserLevel { get; set; } = null!;

    [Column("UserGroupUID")]
    public Guid UserGroupUid { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string UserCode { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string TelephoneNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastLoginDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }
}
