using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwVoucherMatchInDetail
{
    [Column("VoucherMatchLinkUID")]
    public Guid? VoucherMatchLinkUid { get; set; }

    [Column("DrVoucherMatchUID")]
    public Guid DrVoucherMatchUid { get; set; }

    [Column("CrVoucherMatchUID")]
    public Guid? CrVoucherMatchUid { get; set; }

    [Column("AccountUID")]
    public Guid? AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    public int AccountType { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

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
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

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

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

    [Column("LST")]
    [StringLength(50)]
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

    [Column("DrVoucherUID")]
    public Guid? DrVoucherUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DrDocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DrDocDate { get; set; }

    [Column("CrVoucherUID")]
    public Guid? CrVoucherUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CrDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CrDocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CrRealisationDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CreditAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AdjAmt { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("VoucherUID")]
    public Guid? VoucherUid { get; set; }
}
