using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DICMaster")]
public partial class Dicmaster
{
    [Key]
    [Column("DICUID")]
    public Guid Dicuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    public bool? IsStanesDealer { get; set; }

    [Column("DealersUID")]
    public Guid? DealersUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? DealersCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DealersName { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TerritoryName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? HeadQuarter { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Region { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? MarketName { get; set; }

    [Column("Taluq_Mandal")]
    [StringLength(150)]
    [Unicode(false)]
    public string? TaluqMandal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? YearofEstablishment { get; set; }

    public bool? IsNatureofCounter { get; set; }

    public bool? IsWholesale { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Wholesale { get; set; }

    public bool? IsRetail { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Retail { get; set; }

    public bool? IsCommissionAgent { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CommissionAgent { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
