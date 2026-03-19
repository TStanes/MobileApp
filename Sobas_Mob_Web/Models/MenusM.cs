using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("MenusM")]
public partial class MenusM
{
    [Key]
    [Column("MenuUID")]
    public Guid MenuUid { get; set; }

    [Column("MenuID")]
    public int MenuId { get; set; }

    public int MenuSlNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string MenuDesc { get; set; } = null!;

    [Column("ParentMenuUID")]
    public Guid ParentMenuUid { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string FormName { get; set; } = null!;

    [Column("HLevel")]
    public int Hlevel { get; set; }

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

    public bool IsParent { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string MenuType { get; set; } = null!;

    [InverseProperty("MenuU")]
    public virtual ICollection<UserRight> UserRights { get; set; } = new List<UserRight>();
}
