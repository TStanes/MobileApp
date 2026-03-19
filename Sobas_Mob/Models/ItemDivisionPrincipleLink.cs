using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemDivisionPrincipleLink")]
[Index("CreatedDate", Name = "IX_ItemDivisionPrincipleLink_CreatedDate_Includes")]
[Index("ModifiedDate", Name = "IX_ItemDivisionPrincipleLink_ModifiedDate_Includes")]
public partial class ItemDivisionPrincipleLink
{
    [Key]
    [Column("ItemDivisionPrincipleLinkUID")]
    public Guid ItemDivisionPrincipleLinkUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

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

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("ItemDivisionPrincipleLinks")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemDivisionPrincipleLinks")]
    public virtual ItemM ItemU { get; set; } = null!;
}
