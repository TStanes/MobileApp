using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("MonthEndProcedureM")]
public partial class MonthEndProcedureM
{
    [Key]
    [Column("MonthEndProcedureUID")]
    public Guid MonthEndProcedureUid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string ProcedureName { get; set; } = null!;

    [Column("ParentProcedureUID")]
    public Guid ParentProcedureUid { get; set; }

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
