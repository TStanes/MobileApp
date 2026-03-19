using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("AA_PartyShipTo")]
public partial class AaPartyShipTo
{
    [Column("PartyShipToUID")]
    public Guid PartyShipToUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

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

    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

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

    [Column("GSTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gstno { get; set; } = null!;
}
