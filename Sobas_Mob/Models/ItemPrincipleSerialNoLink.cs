using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemPrincipleSerialNoLink")]
[Index("CreatedDate", Name = "IX_ItemPrincipleSerialNoLink_CreatedDate_Includes")]
[Index("ModifiedDate", Name = "IX_ItemPrincipleSerialNoLink_ModifiedDate_Includes")]
public partial class ItemPrincipleSerialNoLink
{
    [Key]
    [Column("ItemPrincipleSerialNoLinkUID")]
    public Guid ItemPrincipleSerialNoLinkUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("PrincipleSerialNumberUID")]
    public Guid PrincipleSerialNumberUid { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemPrincipleSerialNoLinks")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("PrincipleSerialNumberUid")]
    [InverseProperty("ItemPrincipleSerialNoLinks")]
    public virtual PrincipleSerialNumber PrincipleSerialNumberU { get; set; } = null!;
}
