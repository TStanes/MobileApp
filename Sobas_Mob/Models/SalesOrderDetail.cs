using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SalesOrderDetail")]
public partial class SalesOrderDetail
{
    [Key]
    [Column("SalesOrderDetailUID")]
    public Guid SalesOrderDetailUid { get; set; }

    [Column("SalesOrderHdrUID")]
    public Guid SalesOrderHdrUid { get; set; }

    [Column("SalesOrderNoUID")]
    public Guid? SalesOrderNoUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal OrderQty { get; set; }

    public string Remarks { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

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
