using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Medicaltrans_15_16")]
public partial class Medicaltrans1516
{
    [Column("MedicaltransUID")]
    public Guid MedicaltransUid { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    public int Employeeid { get; set; }

    public int FinancialYear { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal EligibleAmount { get; set; }

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
