using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ContractorFunctionMaster")]
public partial class ContractorFunctionMaster
{
    [Key]
    [Column("FunctionUID")]
    public Guid FunctionUid { get; set; }

    [StringLength(200)]
    public string FunctionName { get; set; } = null!;

    public bool RefSobasDoc { get; set; }

    [StringLength(10)]
    public string ConvFact { get; set; } = null!;

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("ITSectionUID")]
    public Guid ItsectionUid { get; set; }

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
