using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UserGroupDivisionMappingM")]
public partial class UserGroupDivisionMappingM
{
    [Key]
    [Column("UserGroupDivisionMappingUID")]
    public Guid UserGroupDivisionMappingUid { get; set; }

    [Column("UserGroupUID")]
    public Guid UserGroupUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

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

    [ForeignKey("DivisionUid")]
    [InverseProperty("UserGroupDivisionMappingMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("UserGroupUid")]
    [InverseProperty("UserGroupDivisionMappingMs")]
    public virtual UserGroupM UserGroupU { get; set; } = null!;
}
