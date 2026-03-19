using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DICTopProgresiveVillagesFarmers")]
public partial class DictopProgresiveVillagesFarmer
{
    [Key]
    [Column("DICTopProgresiveVillagesFarmersUID")]
    public Guid DictopProgresiveVillagesFarmersUid { get; set; }

    [Column("DICUID")]
    public Guid Dicuid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NameOftheVillage { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NameOftheFarmer { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

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
