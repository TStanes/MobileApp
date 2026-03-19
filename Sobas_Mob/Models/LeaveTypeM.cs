using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("LeaveTypeM")]
public partial class LeaveTypeM
{
    [Key]
    [Column("LeaveTypeUID")]
    public Guid LeaveTypeUid { get; set; }

    [StringLength(50)]
    public string LeaveTypeCode { get; set; } = null!;

    [StringLength(200)]
    public string LeaveTypeDesc { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("LeaveTypeU")]
    public virtual ICollection<EmployeeAnnualLeaveM> EmployeeAnnualLeaveMs { get; set; } = new List<EmployeeAnnualLeaveM>();
}
