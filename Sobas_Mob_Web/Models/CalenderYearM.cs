using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("CalenderYearM")]
public partial class CalenderYearM
{
    [Key]
    [Column("CalenderYearUID")]
    public Guid CalenderYearUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CurrentYear { get; set; } = null!;

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

    [InverseProperty("CalenderYearU")]
    public virtual ICollection<EmployeeAnnualLeaveM> EmployeeAnnualLeaveMs { get; set; } = new List<EmployeeAnnualLeaveM>();
}
