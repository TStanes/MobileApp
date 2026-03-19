using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PackM")]
public partial class PackM
{
    [Key]
    [Column("PackUID")]
    public Guid PackUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PackCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PackDesc { get; set; } = null!;

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

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? PricePerUnit { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("PackMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("PackU")]
    public virtual ICollection<ItemRequestPack> ItemRequestPacks { get; set; } = new List<ItemRequestPack>();
}
