using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class EmployeeLeaveDetail
{
    [Key]
    [Column("EmployeeLeaveDetailsUID")]
    public Guid EmployeeLeaveDetailsUid { get; set; }

    [Column("EmployeeAnnualLeaveUID")]
    public Guid EmployeeAnnualLeaveUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [StringLength(500)]
    public string Reason { get; set; } = null!;

    [Column(TypeName = "decimal(18, 1)")]
    public decimal NoofDays { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("EmployeeAnnualLeaveUid")]
    [InverseProperty("EmployeeLeaveDetails")]
    public virtual EmployeeAnnualLeaveM EmployeeAnnualLeaveU { get; set; } = null!;
}
