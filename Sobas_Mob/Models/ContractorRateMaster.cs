using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ContractorRateMaster")]
public partial class ContractorRateMaster
{
    [Key]
    [Column("ContractorRateUID")]
    public Guid ContractorRateUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("FunctionUID")]
    public Guid FunctionUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Commision1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Commision2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ValidFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ValidTo { get; set; }

    public bool Isactive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
