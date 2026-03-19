using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("QuarterM")]
public partial class QuarterM
{
    [Key]
    [Column("QuarterUID")]
    public Guid QuarterUid { get; set; }

    [StringLength(10)]
    public string QuarterNo { get; set; } = null!;

    [StringLength(50)]
    public string StartMonth { get; set; } = null!;

    [StringLength(50)]
    public string EndMonth { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

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
