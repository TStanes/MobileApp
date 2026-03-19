using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PartyAddressDetailsBranchRequest")]
public partial class PartyAddressDetailsBranchRequest
{
    [Key]
    [Column("RequestPartyAddressDetailUID")]
    public Guid RequestPartyAddressDetailUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PartyTitle { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PartyInitials { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid DealerCategoryUid { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PinCode { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string TelephoneNo { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string FaxNo { get; set; } = null!;

    [Column("LST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Lst { get; set; } = null!;

    [Column("PANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string Panno { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ExciseNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ExciseOffice { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string WebAddress { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FertLicenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PestLicenceNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ContactPerson { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string ContactPersonPhoneNo { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
