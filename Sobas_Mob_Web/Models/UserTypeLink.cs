using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UserTypeLink")]
public partial class UserTypeLink
{
    [Key]
    [Column("UserUID")]
    public Guid UserUid { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string UserType { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("UserUid")]
    [InverseProperty("UserTypeLink")]
    public virtual User UserU { get; set; } = null!;
}
