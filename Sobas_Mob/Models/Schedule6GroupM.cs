using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("Schedule6GroupM")]
public partial class Schedule6GroupM
{
    [Key]
    [Column("Schedule6GroupUID")]
    public Guid Schedule6GroupUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Schedule6GroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Schedule6GroupDesc { get; set; } = null!;

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
