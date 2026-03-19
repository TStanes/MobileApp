using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("MonthendProcedureCheckList")]
public partial class MonthendProcedureCheckList
{
    [Key]
    [Column("MonthEndProcedureCheckListUID")]
    public Guid MonthEndProcedureCheckListUid { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    [Column("MonthEndProcedureUID")]
    public Guid MonthEndProcedureUid { get; set; }

    [Column("executed")]
    public bool? Executed { get; set; }

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
