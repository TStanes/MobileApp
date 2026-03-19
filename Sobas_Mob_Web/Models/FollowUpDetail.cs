using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FollowUpDetail")]
public partial class FollowUpDetail
{
    [Key]
    [Column("FollowUpDetailUID")]
    public Guid FollowUpDetailUid { get; set; }

    [Column("EnquiryMUID")]
    public Guid? EnquiryMuid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ConPerson { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Discussion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FollowUpDate { get; set; }

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

    [ForeignKey("EnquiryMuid")]
    [InverseProperty("FollowUpDetails")]
    public virtual EnquiryM? EnquiryMu { get; set; }

    [ForeignKey("PartyUid")]
    [InverseProperty("FollowUpDetails")]
    public virtual PartyM? PartyU { get; set; }
}
