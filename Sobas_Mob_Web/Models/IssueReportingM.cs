using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("IssueReportingM")]
public partial class IssueReportingM
{
    [Key]
    [Column("IssueReportingUID")]
    public Guid IssueReportingUid { get; set; }

    [Column("MenuUID")]
    public Guid MenuUid { get; set; }

    [Column(TypeName = "ntext")]
    public string IssueDescription { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[]? IssueImage { get; set; }

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

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }
}
