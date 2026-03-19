using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ContractorTranReqDetail")]
public partial class ContractorTranReqDetail
{
    [Key]
    [Column("ContPayReqDetailUID")]
    public Guid ContPayReqDetailUid { get; set; }

    [Column("ContPayReqHeaderUID")]
    public Guid ContPayReqHeaderUid { get; set; }

    [Column("ContRateUID")]
    public Guid ContRateUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReqDateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReqDateTo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqSysQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqActualQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqConvFact { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayReqRate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PayreqAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CommisionPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CommisionAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DeductionAmount { get; set; }

    [StringLength(200)]
    public string DeductionReason { get; set; } = null!;

    [Column("ESIPer", TypeName = "decimal(18, 3)")]
    public decimal Esiper { get; set; }

    [Column("ESIAmount", TypeName = "decimal(18, 3)")]
    public decimal Esiamount { get; set; }

    [Column("PFPer", TypeName = "decimal(18, 3)")]
    public decimal Pfper { get; set; }

    [Column("PFAmount", TypeName = "decimal(18, 3)")]
    public decimal Pfamount { get; set; }

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
