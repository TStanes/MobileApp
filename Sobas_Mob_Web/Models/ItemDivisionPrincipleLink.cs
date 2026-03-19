using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemDivisionPrincipleLink")]
[Index("IsActive", "DivisionPrincipleUid", "ItemUid", Name = "_dta_index_ItemDivisionPrincipleLink_5_1095674951__K5_K4_K2_1")]
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
