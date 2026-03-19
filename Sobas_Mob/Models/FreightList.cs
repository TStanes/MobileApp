using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FreightList")]
public partial class FreightList
{
    [Key]
    [Column("FreightListUID")]
    public Guid FreightListUid { get; set; }

    [Column("FreightHdrUID")]
    public Guid FreightHdrUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("LnBranchUID")]
    public Guid LnBranchUid { get; set; }

    [Column("LnDivisionUID")]
    public Guid LnDivisionUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SupplierInvoiceRate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ActualValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BillValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TonnageDifference { get; set; }

    [Column("LRCharges", TypeName = "decimal(18, 3)")]
    public decimal? Lrcharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? HandlingCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? MultipleLocationDifference { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OthersPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ShortageorLeakage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RateDifference { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Damagestock { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OthersMinus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LnRemarks { get; set; } = null!;

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

    [ForeignKey("FreightHdrUid")]
    [InverseProperty("FreightLists")]
    public virtual FreightHdr FreightHdrU { get; set; } = null!;
}
