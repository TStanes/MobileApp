using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VechicleM")]
[Index("VechicleUid", Name = "_dta_index_VechicleM_5_1124967134__K1_2")]
public partial class VechicleM
{
    [Key]
    [Column("VechicleUID")]
    public Guid VechicleUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VechicleNo { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VechicleType { get; set; } = null!;

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

    [InverseProperty("VechicleU")]
    public virtual ICollection<VechicleTran> VechicleTrans { get; set; } = new List<VechicleTran>();
}
