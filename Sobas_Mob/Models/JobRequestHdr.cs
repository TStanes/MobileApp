using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("JobRequestHdr")]
public partial class JobRequestHdr
{
    [Key]
    [Column("JobRequestHdrUID")]
    public Guid JobRequestHdrUid { get; set; }

    [Column("CalenderYearUID")]
    public Guid CalenderYearUid { get; set; }

    [StringLength(50)]
    public string JobOrderNo { get; set; } = null!;

    [StringLength(50)]
    public string JobRequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime JobRequestDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfReceipt { get; set; }

    [Column("IsNABL")]
    public bool IsNabl { get; set; }

    [Column("CustomerUID")]
    public Guid? CustomerUid { get; set; }

    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string TelephoneNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(150)]
    public string SamplingDetails { get; set; } = null!;

    [StringLength(150)]
    public string MethodofSampling { get; set; } = null!;

    [StringLength(150)]
    public string AnalyticalDiscipline { get; set; } = null!;

    [StringLength(150)]
    public string AnalyticalGroup { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SampleGiven { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ChargeCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ClientsMark { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string NatureoftheSample { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Sampletobestoredin { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ConditionofPackage { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ConditionStatus { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Clarificationstobesought { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Testtobesubcontracted { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Details { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RejectionReason { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool MoveToTesting { get; set; }

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

    [InverseProperty("JobRequestHdrU")]
    public virtual ICollection<JobRequestList> JobRequestLists { get; set; } = new List<JobRequestList>();
}
