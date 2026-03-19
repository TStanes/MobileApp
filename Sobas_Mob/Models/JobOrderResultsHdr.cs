using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("JobOrderResultsHdr")]
public partial class JobOrderResultsHdr
{
    [Key]
    [Column("JobOrderResultsHdrUID")]
    public Guid JobOrderResultsHdrUid { get; set; }

    [Column("JobRequestHdrUID")]
    public Guid JobRequestHdrUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ReportRefNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReportRefdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AnalysisStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AnalysisCompletionDate { get; set; }

    [StringLength(500)]
    public string Note { get; set; } = null!;

    public bool MoveToTestReport { get; set; }

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
}
