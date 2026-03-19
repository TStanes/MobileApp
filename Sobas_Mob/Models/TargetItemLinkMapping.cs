using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TargetItemLinkMapping")]
public partial class TargetItemLinkMapping
{
    [Key]
    [Column("TargetItemLinkUID")]
    public Guid TargetItemLinkUid { get; set; }

    [Column("TargetUID")]
    public Guid TargetUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

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

    [ForeignKey("ItemGroupUid")]
    [InverseProperty("TargetItemLinkMappings")]
    public virtual ItemGroupM? ItemGroupU { get; set; }

    [ForeignKey("ItemSubGroupUid")]
    [InverseProperty("TargetItemLinkMappings")]
    public virtual ItemSubGroupM? ItemSubGroupU { get; set; }

    [ForeignKey("ItemUid")]
    [InverseProperty("TargetItemLinkMappings")]
    public virtual ItemM? ItemU { get; set; }

    [ForeignKey("TargetUid")]
    [InverseProperty("TargetItemLinkMappings")]
    public virtual TargetM TargetU { get; set; } = null!;
}
