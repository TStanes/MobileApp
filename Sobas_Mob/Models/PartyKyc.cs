using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("Party_KYC")]
public partial class PartyKyc
{
    public double? Branchcode { get; set; }

    [StringLength(255)]
    public string? StateDesc { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [Key]
    [StringLength(10)]
    public string PartyCode { get; set; } = null!;

    [Column("partyName")]
    [StringLength(255)]
    public string? PartyName { get; set; }

    [StringLength(255)]
    public string? ShopAddress1 { get; set; }

    [StringLength(255)]
    public string? ShopAddress2 { get; set; }

    [StringLength(255)]
    public string? ShopAddress3 { get; set; }

    [StringLength(255)]
    public string? ShopAddress4 { get; set; }

    [Column("SCity")]
    [StringLength(255)]
    public string? Scity { get; set; }

    [Column("SPinCode")]
    public double? SpinCode { get; set; }

    [Column("SState")]
    [StringLength(255)]
    public string? Sstate { get; set; }

    [Column("Owner name")]
    [StringLength(255)]
    public string? OwnerName { get; set; }

    [StringLength(255)]
    public string? ResidentialAddress1 { get; set; }

    [StringLength(255)]
    public string? ResidentialAddress2 { get; set; }

    [StringLength(255)]
    public string? ResidentialAddress3 { get; set; }

    [StringLength(255)]
    public string? ResidentialAddress4 { get; set; }

    [Column("RCity")]
    [StringLength(255)]
    public string? Rcity { get; set; }

    [Column("RState")]
    [StringLength(255)]
    public string? Rstate { get; set; }

    [Column("RPinCode")]
    public double? RpinCode { get; set; }

    public double? MobileNo { get; set; }

    public double? WhatsappMobileNo { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [Column("GSTNo")]
    [StringLength(255)]
    public string? Gstno { get; set; }

    [Column("PANNo")]
    [StringLength(255)]
    public string? Panno { get; set; }

    [StringLength(255)]
    public string? BankAccountNo { get; set; }

    [Column("IFSCCode")]
    [StringLength(255)]
    public string? Ifsccode { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? MobNo { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? WhatsAppNo { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
