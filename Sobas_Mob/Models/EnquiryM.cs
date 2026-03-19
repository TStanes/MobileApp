using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EnquiryM")]
public partial class EnquiryM
{
    [Key]
    [Column("EnquiryMUID")]
    public Guid EnquiryMuid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("AreaUID")]
    public Guid? AreaUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyInitials { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? WebAddress { get; set; }

    [StringLength(10)]
    public string? EnquiryType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnquiryDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OtherPaymentMode { get; set; }

    [Column("LCDays")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lcdays { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TentativeDelSch { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreditPeriod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ContactPersonPhoneNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OtherInfo { get; set; }

    public bool InsertInToPartyM { get; set; }

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

    [InverseProperty("EnquiryMu")]
    public virtual ICollection<FollowUpDetail> FollowUpDetails { get; set; } = new List<FollowUpDetail>();

    [InverseProperty("EnquiryPartyU")]
    public virtual ICollection<ProformaInvoiceHeader> ProformaInvoiceHeaders { get; set; } = new List<ProformaInvoiceHeader>();
}
