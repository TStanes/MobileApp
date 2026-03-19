using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("AreaM")]
public partial class AreaM
{
    [Key]
    [Column("AreaUID")]
    public Guid AreaUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string AreaDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string AreaAbbr { get; set; } = null!;

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

    [ForeignKey("BranchUid")]
    [InverseProperty("AreaMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [InverseProperty("AreaU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();
}
