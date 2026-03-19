using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TTCDivision")]
public partial class Ttcdivision
{
    [Key]
    [Column("TTCDivisionUID")]
    public Guid TtcdivisionUid { get; set; }

    [Column("TransactionTypeConfigurationUID")]
    public Guid TransactionTypeConfigurationUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

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
