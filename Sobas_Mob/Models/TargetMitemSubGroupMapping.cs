using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TargetMItemSubGroupMapping")]
public partial class TargetMitemSubGroupMapping
{
    [Key]
    [Column("TargetItemSubGroupUID")]
    public Guid TargetItemSubGroupUid { get; set; }

    [Column("TargetUID")]
    public Guid TargetUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

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
}
