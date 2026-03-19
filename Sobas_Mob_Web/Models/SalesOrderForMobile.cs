using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SalesOrderForMobile")]
public partial class SalesOrderForMobile
{
    [Key]
    [Column("SalesOrderUID")]
    public Guid SalesOrderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDescription { get; set; } = null!;

    public int Quantity { get; set; }

    [StringLength(250)]
    public string Specifications { get; set; } = null!;

    [StringLength(500)]
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
