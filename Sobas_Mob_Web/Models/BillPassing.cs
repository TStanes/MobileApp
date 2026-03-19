using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BillPassing")]
public partial class BillPassing
{
    [Key]
    [Column("BillPassingUID")]
    public Guid BillPassingUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    public int FinYr { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BillPassingDocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BillPassingDate { get; set; }

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AmountSanctioned { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalUnAdjustedCreditAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalUnAdjustedDebitAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal BillsPayableAmount { get; set; }

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
}
