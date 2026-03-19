using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class UserRight
{
    [Key]
    [Column("UserRightsUID")]
    public Guid UserRightsUid { get; set; }

    [Column("UserUID")]
    public Guid UserUid { get; set; }

    [Column("MenuUID")]
    public Guid MenuUid { get; set; }

    [Column("M_Add")]
    public bool MAdd { get; set; }

    [Column("M_Edit")]
    public bool MEdit { get; set; }

    [Column("M_Delete")]
    public bool MDelete { get; set; }

    [Column("OF_Add")]
    public bool OfAdd { get; set; }

    [Column("OF_Edit")]
    public bool OfEdit { get; set; }

    [Column("OF_Delete")]
    public bool OfDelete { get; set; }

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

    [ForeignKey("MenuUid")]
    [InverseProperty("UserRights")]
    public virtual MenusM MenuU { get; set; } = null!;
}
