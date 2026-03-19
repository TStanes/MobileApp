using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("MedicaltransList")]
public partial class MedicaltransList
{
    [Key]
    [Column("MedicaltransListUID")]
    public Guid MedicaltransListUid { get; set; }

    [Column("MedicaltransUID")]
    public Guid MedicaltransUid { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    public int Employeeid { get; set; }

    public int FinancialYear { get; set; }

    [StringLength(50)]
    public string VoucherNo { get; set; } = null!;

    [StringLength(50)]
    public string PayMode { get; set; } = null!;

    [Column(TypeName = "numeric(18, 3)")]
    public decimal ClaimedAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ClaimedDate { get; set; }

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

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
