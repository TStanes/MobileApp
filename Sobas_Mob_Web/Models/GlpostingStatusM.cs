using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("GLPostingStatusM")]
public partial class GlpostingStatusM
{
    [Key]
    [Column("GLPostingStatusUID")]
    public Guid GlpostingStatusUid { get; set; }

    [Column("GLPostingStatusCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string GlpostingStatusCode { get; set; } = null!;

    [Column("GLPostingStatusDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string GlpostingStatusDesc { get; set; } = null!;

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
}
