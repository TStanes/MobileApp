using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UserTypeM")]
public partial class UserTypeM
{
    [Key]
    [Column("UserTypeUID")]
    public Guid UserTypeUid { get; set; }

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
}
