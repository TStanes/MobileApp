using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FreeItemM")]
public partial class FreeItemM
{
    [Key]
    [Column("FreeItemMUID")]
    public Guid FreeItemMuid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string FreeCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FreeDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("SelectedItemUID")]
    public Guid SelectedItemUid { get; set; }

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

    [InverseProperty("FreeItemMu")]
    public virtual ICollection<FreeItemQty> FreeItemQties { get; set; } = new List<FreeItemQty>();

    [ForeignKey("SelectedItemUid")]
    [InverseProperty("FreeItemMs")]
    public virtual ItemM SelectedItemU { get; set; } = null!;
}
