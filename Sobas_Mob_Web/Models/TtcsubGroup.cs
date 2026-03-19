using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TTCSubGroup")]
public partial class TtcsubGroup
{
    [Key]
    [Column("TTCSubGroupUID")]
    public Guid TtcsubGroupUid { get; set; }

    [Column("TransactionTypeConfigurationUID")]
    public Guid TransactionTypeConfigurationUid { get; set; }

    [Column("SubGroupUID")]
    public Guid SubGroupUid { get; set; }

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
