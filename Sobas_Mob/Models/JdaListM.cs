using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("JdaListM")]
public partial class JdaListM
{
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [ForeignKey("PartyCode")]
    [InverseProperty("JdaListM")]
    public virtual PartyM PartyCodeNavigation { get; set; } = null!;
}
