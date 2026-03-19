using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyOtherDetailsBranchRequest")]
public partial class PartyOtherDetailsBranchRequest
{
    [Key]
    [Column("RequestPartyOtherDetailUID")]
    public Guid RequestPartyOtherDetailUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column("AreaUID")]
    public Guid? AreaUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseDivision { get; set; }

    [Column("GSTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gstno { get; set; }

    [Unicode(false)]
    public string RequestFor { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
