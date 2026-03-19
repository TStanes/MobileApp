using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("InventoryTransListExtn")]
[Index("CreatedDate", Name = "_dta_index_InventoryTransListExtn_7_1924306015__K26")]
public partial class InventoryTransListExtn
{
    [Key]
    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("ReturnedByUID")]
    public Guid? ReturnedByUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnedDate { get; set; }

    [Column("DNRRNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dnrrno { get; set; }

    [Column(TypeName = "text")]
    public string? ItemConditionReport { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Make { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Process { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Grade { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RetreadingCharges { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RepairCharges { get; set; }

    [Column("ServiceUID")]
    public Guid? ServiceUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ServicePer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmt { get; set; }

    [Column("ServiceCessUID")]
    public Guid? ServiceCessUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ServiceCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ServiceCessAmt { get; set; }

    [Column("ServiceHEduCessUID")]
    public Guid? ServiceHeduCessUid { get; set; }

    [Column("ServiceHEduCessPer", TypeName = "decimal(18, 2)")]
    public decimal? ServiceHeduCessPer { get; set; }

    [Column("ServiceHEduCessAmt", TypeName = "decimal(18, 3)")]
    public decimal? ServiceHeduCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PostedValue { get; set; }

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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? TaxPosted { get; set; }

    [Column("EDHrEduCessPer", TypeName = "decimal(18, 3)")]
    public decimal? EdhrEduCessPer { get; set; }

    [Column("EDHrEduCessAmt", TypeName = "decimal(18, 3)")]
    public decimal? EdhrEduCessAmt { get; set; }
}
