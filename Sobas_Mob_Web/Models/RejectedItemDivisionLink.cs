using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[PrimaryKey("ItemUid", "DivisionUid")]
[Table("RejectedItemDivisionLink")]
public partial class RejectedItemDivisionLink
{
    [Key]
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Key]
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

    [ForeignKey("ItemUid")]
    [InverseProperty("RejectedItemDivisionLinks")]
    public virtual RejectedItemM ItemU { get; set; } = null!;
}
