using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ContractorTranFnLink")]
public partial class ContractorTranFnLink
{
    [Key]
    [Column("ContractorTranFnLinkUID")]
    public Guid ContractorTranFnLinkUid { get; set; }

    [Column("FunctionUID")]
    public Guid FunctionUid { get; set; }

    [Column("TransactionTypesUID")]
    public Guid TransactionTypesUid { get; set; }

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
