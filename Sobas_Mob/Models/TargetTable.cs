using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetTable")]
public partial class TargetTable
{
    [Column("BudgetUID")]
    public Guid? BudgetUid { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("month")]
    public DateOnly? Month { get; set; }

    [Column("itemUID")]
    public Guid? ItemUid { get; set; }

    [Column("salesqty")]
    public int? Salesqty { get; set; }
}
