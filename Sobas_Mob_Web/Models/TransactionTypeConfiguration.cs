using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TransactionTypeConfiguration")]
public partial class TransactionTypeConfiguration
{
    [Key]
    [Column("TransactionTypeConfigurationUID")]
    public Guid TransactionTypeConfigurationUid { get; set; }

    [Column("TransactionTypeUID")]
    public Guid TransactionTypeUid { get; set; }

    [Column("AffectedAccountUID")]
    public Guid AffectedAccountUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    public bool? Branch { get; set; }

    public bool Division { get; set; }

    public bool Category { get; set; }

    public bool State { get; set; }

    public bool SubGroup { get; set; }

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

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [ForeignKey("TransactionTypeUid")]
    [InverseProperty("TransactionTypeConfigurations")]
    public virtual TransactionTypesM TransactionTypeU { get; set; } = null!;

    [InverseProperty("TransactionTypeConfigurationU")]
    public virtual ICollection<Ttcbranch> Ttcbranches { get; set; } = new List<Ttcbranch>();
}
