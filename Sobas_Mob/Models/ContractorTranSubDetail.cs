using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ContractorTranSubDetail")]
public partial class ContractorTranSubDetail
{
    [Column("ContPayReqDetailUID")]
    public Guid ContPayReqDetailUid { get; set; }

    [StringLength(50)]
    public string InventoryDocNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InventoryDocQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ActCalcQty { get; set; }

    [Column("isActive")]
    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate1 { get; set; }

    [ForeignKey("ContPayReqDetailUid")]
    public virtual ContractorTranReqDetail ContPayReqDetailU { get; set; } = null!;
}
