using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("RejectedItemRequestPack")]
public partial class RejectedItemRequestPack
{
    [Key]
    [Column("ItemRequestPackUID")]
    public Guid ItemRequestPackUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("PackUID")]
    public Guid PackUid { get; set; }

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
    [InverseProperty("RejectedItemRequestPacks")]
    public virtual RejectedItemM ItemU { get; set; } = null!;
}
