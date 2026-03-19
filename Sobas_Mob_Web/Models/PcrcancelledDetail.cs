using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PCRCancelledDetails")]
public partial class PcrcancelledDetail
{
    [Key]
    [Column("PCRCancelledUID")]
    public Guid PcrcancelledUid { get; set; }

    [Column("PCRUID")]
    public Guid Pcruid { get; set; }

    public int FromNo { get; set; }

    public int ToNo { get; set; }

    [StringLength(50)]
    public string? Reason { get; set; }

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

    [ForeignKey("Pcruid")]
    [InverseProperty("PcrcancelledDetails")]
    public virtual Pcrdetail Pcru { get; set; } = null!;
}
