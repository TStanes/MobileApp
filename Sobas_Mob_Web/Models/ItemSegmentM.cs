using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemSegmentM")]
public partial class ItemSegmentM
{
    [Key]
    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ItemSegmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemSegmentDesc { get; set; } = null!;

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

    [InverseProperty("ItemSegmentU")]
    public virtual ICollection<ItemGroupM> ItemGroupMs { get; set; } = new List<ItemGroupM>();

    [InverseProperty("ItemSegmentU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();
}
