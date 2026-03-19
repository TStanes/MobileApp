using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BCERequestLevelPercentage")]
public partial class BcerequestLevelPercentage
{
    [Key]
    [Column("BCERequestLevelPerUID")]
    public Guid BcerequestLevelPerUid { get; set; }

    [Column("BCEReimbLevelper", TypeName = "decimal(18, 2)")]
    public decimal BcereimbLevelper { get; set; }

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
