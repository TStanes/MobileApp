using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PurchaseInvoiceHeaderExtn")]
public partial class PurchaseInvoiceHeaderExtn
{
    [Key]
    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [Column("CFormNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CformNo { get; set; }

    [Column("CFromDate", TypeName = "datetime")]
    public DateTime? CfromDate { get; set; }

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
}
