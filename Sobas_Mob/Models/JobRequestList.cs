using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("JobRequestList")]
public partial class JobRequestList
{
    [Key]
    [Column("JobRequestListUID")]
    public Guid JobRequestListUid { get; set; }

    [Column("JobRequestHdrUID")]
    public Guid JobRequestHdrUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string NameOfSample { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DescriptionOfSample { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SampleSerialNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Quantity { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TesttobeconductedIn { get; set; } = null!;

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

    [ForeignKey("JobRequestHdrUid")]
    [InverseProperty("JobRequestLists")]
    public virtual JobRequestHdr JobRequestHdrU { get; set; } = null!;

    [InverseProperty("JobRequestListU")]
    public virtual ICollection<JobRequestListExtn> JobRequestListExtns { get; set; } = new List<JobRequestListExtn>();
}
