using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FreeTransLink")]
public partial class FreeTransLink
{
    [Key]
    [Column("FreeTransLinkUID", TypeName = "decimal(18, 0)")]
    public decimal FreeTransLinkUid { get; set; }

    [Column("FreeTransUID", TypeName = "decimal(18, 0)")]
    public decimal FreeTransUid { get; set; }

    [Column("MainTransUID", TypeName = "decimal(18, 0)")]
    public decimal MainTransUid { get; set; }

    public bool IsAcive { get; set; }

    [Column("CreatedBY")]
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
}
