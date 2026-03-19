using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TTCState")]
[Index("TransactionTypeConfigurationUid", Name = "IX_transactiontypeState")]
public partial class Ttcstate
{
    [Key]
    [Column("TTCStateUID")]
    public Guid TtcstateUid { get; set; }

    [Column("TransactionTypeConfigurationUID")]
    public Guid TransactionTypeConfigurationUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

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
