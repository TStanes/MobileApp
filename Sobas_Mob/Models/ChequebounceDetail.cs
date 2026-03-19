using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ChequebounceDetail")]
public partial class ChequebounceDetail
{
    [Key]
    [Column("ChequeBounceDetailUID")]
    public Guid ChequeBounceDetailUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string ChequeBounceDetail { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
