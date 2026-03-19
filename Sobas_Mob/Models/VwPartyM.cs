using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPartyM
{
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("PartyTypeUID")]
    public Guid PartyTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyTypeDesc { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [Column("BranchStateUID")]
    public Guid? BranchStateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchStateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchStateDesc { get; set; }

    [Column("AreaUID")]
    public Guid? AreaUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AreaCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AreaDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AreaAbbr { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Abbriviation { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyInitials { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? PartyAcHead { get; set; }

    [Column("PartyGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyGlcode { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CountryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string CountryName { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? TelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [Column("LST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Lst { get; set; }

    [Column("CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [Column("PANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Panno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ExciseNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? ExciseOffice { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseDivision { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseRange { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? WebAddress { get; set; }

    public bool? VatCovered { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NatureOfBusiness { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FertLicenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PestLicenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ContactPersonPhoneNo { get; set; }

    public bool Legal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionReason { get; set; }

    [Column("DealerCategoryUID")]
    public Guid? DealerCategoryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DealerCategoryCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DealerCategoryDesc { get; set; }

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

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

    [Column("GSTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gstno { get; set; } = null!;
}
