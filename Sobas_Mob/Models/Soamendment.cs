using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SOAmendment")]
public partial class Soamendment
{
    [Key]
    [Column("SOAmendmentUID")]
    public Guid SoamendmentUid { get; set; }

    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal SoheaderUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AmendPlusQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AmendMinusQty { get; set; }

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
