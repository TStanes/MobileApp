using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ContractorTranAppHeader")]
public partial class ContractorTranAppHeader
{
    [Key]
    [Column("ContPayAppHeaderUID")]
    public Guid ContPayAppHeaderUid { get; set; }

    [Column("ContractorUID")]
    public Guid ContractorUid { get; set; }

    [StringLength(15)]
    public string BranchDivContCode { get; set; } = null!;

    [StringLength(15)]
    public string PayReqNo { get; set; } = null!;

    [StringLength(15)]
    public string PayAppNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayAppAmount { get; set; }

    [Column("PayAppCGSTAmount", TypeName = "decimal(18, 3)")]
    public decimal PayAppCgstamount { get; set; }

    [Column("PayAppSGSTAmount", TypeName = "decimal(18, 3)")]
    public decimal PayAppSgstamount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayAppTotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContPayAppDate { get; set; }

    [StringLength(300)]
    public string Remarks { get; set; } = null!;

    public bool AppStatus { get; set; }

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
