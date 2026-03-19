using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("InventoryTransExtn")]
[Index("CreatedDate", Name = "_dta_index_InventoryTransExtn_7_1959066115__K12")]
public partial class InventoryTransExtn
{
    [Key]
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("CFormNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CformNo { get; set; }

    [Column("CFromDate", TypeName = "datetime")]
    public DateTime? CfromDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SpecialInstructions { get; set; }

    [Column("AttendedbyUID")]
    public Guid? AttendedbyUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ServiceTax { get; set; }

    [Column("ServiceCESS", TypeName = "decimal(18, 3)")]
    public decimal? ServiceCess { get; set; }

    [Column("ServiceHEDUCess", TypeName = "decimal(18, 3)")]
    public decimal? ServiceHeducess { get; set; }

    [Column("StockAdjPurposeMUID")]
    public Guid? StockAdjPurposeMuid { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("EDSalesSerialNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EdsalesSerialNo { get; set; }

    [Column("IsEDSale")]
    public bool? IsEdsale { get; set; }

    [Column("EDHrEduCess", TypeName = "decimal(18, 3)")]
    public decimal? EdhrEduCess { get; set; }
}
