using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SalesOrderFromApp")]
public partial class SalesOrderFromApp
{
    [Key]
    [Column("SalesOrderNoUID")]
    public Guid SalesOrderNoUid { get; set; }

    [StringLength(50)]
    public string SalesOrderNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [Column("SoEmpID")]
    public int SoEmpId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal OrderQty { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string DealerCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RequestingBranchCode { get; set; } = null!;

    [Unicode(false)]
    public string? Remarks { get; set; }

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
