using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("UOMM")]
public partial class Uomm
{
    [Key]
    [Column("UOMUID")]
    public Guid Uomuid { get; set; }

    [Column("UOMCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uomcode { get; set; } = null!;

    [Column("UOMDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Uomdesc { get; set; } = null!;

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

    [InverseProperty("Uom2u")]
    public virtual ICollection<ItemM> ItemMUom2us { get; set; } = new List<ItemM>();

    [InverseProperty("Uomu")]
    public virtual ICollection<ItemM> ItemMUomus { get; set; } = new List<ItemM>();
}
