using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("VehicleReimbursementM")]
public partial class VehicleReimbursementM
{
    [Key]
    [Column("VehicleReimbursementUID")]
    public Guid VehicleReimbursementUid { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReimbursementAmount { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("VehicleReimbursementU")]
    public virtual ICollection<VehicleReimbursementDetail> VehicleReimbursementDetails { get; set; } = new List<VehicleReimbursementDetail>();
}
