using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyTypeM")]
public partial class PartyTypeM
{
    [Key]
    [Column("PartyTypeUID")]
    public Guid PartyTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PartyTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyTypeDesc { get; set; } = null!;

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

    [InverseProperty("PartyTypeU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();
}
