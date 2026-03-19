using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DICTopMolecules")]
public partial class DictopMolecule
{
    [Key]
    [Column("DICTopMoleculesUID")]
    public Guid DictopMoleculesUid { get; set; }

    [Column("DICUID")]
    public Guid Dicuid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NameOftheMolecules { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
