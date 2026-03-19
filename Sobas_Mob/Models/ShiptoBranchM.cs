using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ShiptoBranchM")]
public partial class ShiptoBranchM
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TelephoneNo { get; set; } = null!;

    [Column("CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [Column("TNGST")]
    [StringLength(20)]
    [Unicode(false)]
    public string Tngst { get; set; } = null!;

    [Column("ParentBranchUID")]
    public Guid? ParentBranchUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BranchType { get; set; } = null!;

    public bool IsCostCal { get; set; }

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

    [Column("CERegnNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CeregnNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TarriffHeadingNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Range { get; set; }

    [Column("EDDivision")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Eddivision { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CommissionRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NotificationValid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute7 { get; set; }
}
