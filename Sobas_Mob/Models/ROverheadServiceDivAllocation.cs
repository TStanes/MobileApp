using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("R_Overhead_ServiceDiv_Allocation")]
public partial class ROverheadServiceDivAllocation
{
    [Key]
    [Column("OverheadServiceDivAllocationUID")]
    public Guid OverheadServiceDivAllocationUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [StringLength(50)]
    public string TranType { get; set; } = null!;

    [Column("Income_ExpensesType")]
    [StringLength(255)]
    public string IncomeExpensesType { get; set; } = null!;

    [Column("OPD", TypeName = "decimal(12, 2)")]
    public decimal Opd { get; set; }

    [Column("APD", TypeName = "decimal(12, 2)")]
    public decimal Apd { get; set; }

    [Column("CIPD", TypeName = "decimal(12, 2)")]
    public decimal Cipd { get; set; }

    [Column("EXPORTS", TypeName = "decimal(12, 2)")]
    public decimal Exports { get; set; }

    [Column("AHD", TypeName = "decimal(12, 2)")]
    public decimal Ahd { get; set; }

    [Column("AED", TypeName = "decimal(12, 2)")]
    public decimal Aed { get; set; }

    [Column("TOTAL", TypeName = "decimal(12, 2)")]
    public decimal Total { get; set; }

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

    [Column("AHCD", TypeName = "decimal(8, 3)")]
    public decimal? Ahcd { get; set; }

    [Column(TypeName = "decimal(8, 3)")]
    public decimal? Service { get; set; }
}
