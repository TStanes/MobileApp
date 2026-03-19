using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FreightHdr")]
public partial class FreightHdr
{
    [Key]
    [Column("FreightHdrUID")]
    public Guid FreightHdrUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string BillNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BillDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BillAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalBillValue { get; set; }

    [Column("TDSAccountUID")]
    public Guid? TdsaccountUid { get; set; }

    [Column("TDSAmount", TypeName = "decimal(18, 3)")]
    public decimal Tdsamount { get; set; }

    [Column("SGSTUID")]
    public Guid? Sgstuid { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTUID")]
    public Guid? Cgstuid { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTUID")]
    public Guid? Igstuid { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal GrossValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Roundoff { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetValue { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column("StatusUID")]
    public Guid? StatusUid { get; set; }

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

    [InverseProperty("FreightHdrU")]
    public virtual ICollection<FreightList> FreightLists { get; set; } = new List<FreightList>();
}
