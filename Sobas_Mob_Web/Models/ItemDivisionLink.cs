using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemDivisionLink")]
public partial class ItemDivisionLink
{
    [Key]
    [Column("ItemDivisionLinkUID")]
    public Guid ItemDivisionLinkUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

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

    public bool IsParentDivision { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("ItemDivisionLinks")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ItemDivisionLinks")]
    public virtual ItemM ItemU { get; set; } = null!;
}
