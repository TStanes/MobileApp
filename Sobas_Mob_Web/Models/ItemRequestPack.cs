using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemRequestPack")]
public partial class ItemRequestPack
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
    [InverseProperty("ItemRequestPacks")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("PackUid")]
    [InverseProperty("ItemRequestPacks")]
    public virtual PackM PackU { get; set; } = null!;
}
