using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[PrimaryKey("ItemUid", "DivisionPrincipleUid")]
[Table("RejectedItemDivisionPrincipleLink")]
public partial class RejectedItemDivisionPrincipleLink
{
    [Key]
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Key]
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

    [ForeignKey("ItemUid")]
    [InverseProperty("RejectedItemDivisionPrincipleLinks")]
    public virtual RejectedItemM ItemU { get; set; } = null!;
}
