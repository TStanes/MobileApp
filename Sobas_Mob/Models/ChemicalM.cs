using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ChemicalM")]
public partial class ChemicalM
{
    [Key]
    [Column("ChemicalUID")]
    public Guid ChemicalUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ChemicalCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ChemicalDesc { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("ChemicalU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();
}
