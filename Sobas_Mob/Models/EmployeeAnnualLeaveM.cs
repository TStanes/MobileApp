using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EmployeeAnnualLeaveM")]
public partial class EmployeeAnnualLeaveM
{
    [Key]
    [Column("EmployeeAnnualLeaveUID")]
    public Guid EmployeeAnnualLeaveUid { get; set; }

    [Column("CalenderYearUID")]
    public Guid CalenderYearUid { get; set; }

    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("LeaveTypeUID")]
    public Guid LeaveTypeUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartOnwards { get; set; }

    [Column(TypeName = "decimal(18, 1)")]
    public decimal NoofDaysAllowed { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("CalenderYearUid")]
    [InverseProperty("EmployeeAnnualLeaveMs")]
    public virtual CalenderYearM CalenderYearU { get; set; } = null!;

    [InverseProperty("EmployeeAnnualLeaveU")]
    public virtual ICollection<EmployeeLeaveDetail> EmployeeLeaveDetails { get; set; } = new List<EmployeeLeaveDetail>();

    [ForeignKey("EmployeeUid")]
    [InverseProperty("EmployeeAnnualLeaveMs")]
    public virtual TaemployeeM EmployeeU { get; set; } = null!;

    [ForeignKey("LeaveTypeUid")]
    [InverseProperty("EmployeeAnnualLeaveMs")]
    public virtual LeaveTypeM LeaveTypeU { get; set; } = null!;
}
