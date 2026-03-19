using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ContractorTranReqHeader")]
public partial class ContractorTranReqHeader
{
    [Key]
    [Column("ContPayReqHeaderUID")]
    public Guid ContPayReqHeaderUid { get; set; }

    [Column("ContractorRateUID")]
    public Guid ContractorRateUid { get; set; }

    [StringLength(15)]
    public string BranchDivContCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ContPayReqDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayReqDate { get; set; }

    [StringLength(15)]
    public string PayReqNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqAmount { get; set; }

    [Column("PayReqCGSTAmount", TypeName = "decimal(18, 3)")]
    public decimal PayReqCgstamount { get; set; }

    [Column("PayReqSGSTAmount", TypeName = "decimal(18, 3)")]
    public decimal PayReqSgstamount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqTotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayReqFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayReqTo { get; set; }

    [StringLength(300)]
    public string Remarks { get; set; } = null!;

    [Column("isActive")]
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
