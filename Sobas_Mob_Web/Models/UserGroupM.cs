using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UserGroupM")]
public partial class UserGroupM
{
    [Key]
    [Column("UserGroupUID")]
    public Guid UserGroupUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UserGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string UserGroupDesc { get; set; } = null!;

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

    [InverseProperty("UserGroupU")]
    public virtual ICollection<UserGroupDivisionMappingM> UserGroupDivisionMappingMs { get; set; } = new List<UserGroupDivisionMappingM>();

    [InverseProperty("UserGroupU")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
