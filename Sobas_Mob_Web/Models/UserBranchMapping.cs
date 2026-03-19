using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UserBranchMapping")]
public partial class UserBranchMapping
{
    [Key]
    [Column("UserBranchMappingUID")]
    public Guid UserBranchMappingUid { get; set; }

    [Column("UserUID")]
    public Guid UserUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

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

    [ForeignKey("UserUid")]
    [InverseProperty("UserBranchMappings")]
    public virtual User UserU { get; set; } = null!;
}
