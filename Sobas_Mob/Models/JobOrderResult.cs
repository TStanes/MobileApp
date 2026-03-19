using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class JobOrderResult
{
    [Key]
    [Column("JobOrderResultsUID")]
    public Guid JobOrderResultsUid { get; set; }

    [Column("JobOrderResultsHdrUID")]
    public Guid JobOrderResultsHdrUid { get; set; }

    [Column("JobRequestListExtnUID")]
    public Guid JobRequestListExtnUid { get; set; }

    [Column("JobRequestListUID")]
    public Guid JobRequestListUid { get; set; }

    [Column("JobRequestHdrUID")]
    public Guid JobRequestHdrUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime JobOrderResultsDate { get; set; }

    [StringLength(500)]
    public string Result { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ObservationNoteBookDetails { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TestedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TestedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VerifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime VerifiedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ApprovedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ApprovedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Specification { get; set; } = null!;

    [StringLength(1)]
    public string Asterisk { get; set; } = null!;

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
}
