using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SalesOrderHdr")]
public partial class SalesOrderHdr
{
    [Key]
    [Column("SalesOrderHdrUID")]
    public Guid SalesOrderHdrUid { get; set; }

    [StringLength(50)]
    public string? SalesOrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SalesOrderDate { get; set; }

    [StringLength(50)]
    public string SalesOrderAppRefNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? SalesOrderAppRefDate { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    public bool IsFromAppData { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(1000)]
    public string? RejectionReason { get; set; }

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
