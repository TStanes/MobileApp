using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("JobRequestListExtn")]
public partial class JobRequestListExtn
{
    [Key]
    [Column("JobRequestListExtnUID")]
    public Guid JobRequestListExtnUid { get; set; }

    [Column("JobRequestListUID")]
    public Guid JobRequestListUid { get; set; }

    [Column("JobRequestHdrUID")]
    public Guid JobRequestHdrUid { get; set; }

    [Column("ParamerUID")]
    public Guid ParamerUid { get; set; }

    [Column("MethodUID")]
    public Guid MethodUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FeasibilityConductTest { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AssignedTo { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

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

    [ForeignKey("JobRequestListUid")]
    [InverseProperty("JobRequestListExtns")]
    public virtual JobRequestList JobRequestListU { get; set; } = null!;
}
