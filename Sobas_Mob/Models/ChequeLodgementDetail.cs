using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ChequeLodgementDetail")]
public partial class ChequeLodgementDetail
{
    [Key]
    [Column("ChequeLodgementDetailUID")]
    public Guid ChequeLodgementDetailUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LodgementDocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LodgementDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(500)]
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
