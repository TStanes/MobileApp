using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("EWaybillDataM")]
public partial class EwaybillDataM
{
    [Key]
    [StringLength(64)]
    public string Irn { get; set; } = null!;

    [StringLength(10)]
    public string? Distance { get; set; }

    [Column("TransID")]
    [StringLength(50)]
    public string? TransId { get; set; }

    [StringLength(150)]
    public string? TransName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransDocDt { get; set; }

    [StringLength(30)]
    public string? TransDocNo { get; set; }

    [StringLength(20)]
    public string? VehNo { get; set; }

    [StringLength(50)]
    public string? AckNo { get; set; }

    [StringLength(50)]
    public string? AckDt { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [StringLength(50)]
    public string? EwbNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EwbDt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EwbValidTill { get; set; }

    [StringLength(200)]
    public string? EwbDist { get; set; }

    [StringLength(300)]
    public string? Remarks { get; set; }

    [StringLength(100)]
    public string? Att1 { get; set; }

    [StringLength(100)]
    public string? Att2 { get; set; }

    [StringLength(100)]
    public string? Att3 { get; set; }

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
