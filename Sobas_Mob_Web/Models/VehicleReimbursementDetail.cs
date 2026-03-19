using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class VehicleReimbursementDetail
{
    [Key]
    [Column("VehicleReimbursementDetailsUID")]
    public Guid VehicleReimbursementDetailsUid { get; set; }

    [Column("VehicleReimbursementUID")]
    public Guid VehicleReimbursementUid { get; set; }

    [StringLength(20)]
    public string StatementNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StatementDate { get; set; }

    [StringLength(50)]
    public string PaymentMode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FuelAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RepairsAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OthersAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TotalAmt { get; set; }

    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("VehicleReimbursementUid")]
    [InverseProperty("VehicleReimbursementDetails")]
    public virtual VehicleReimbursementM VehicleReimbursementU { get; set; } = null!;
}
