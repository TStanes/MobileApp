using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PCRDetails")]
public partial class Pcrdetail
{
    [Key]
    [Column("PCRUID")]
    public Guid Pcruid { get; set; }

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [StringLength(50)]
    public string BookNo { get; set; } = null!;

    public int FromNo { get; set; }

    public int ToNo { get; set; }

    [StringLength(50)]
    public string? IssuedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    [StringLength(50)]
    public string? SendThrough { get; set; }

    public bool? IsReturned { get; set; }

    [StringLength(50)]
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

    [InverseProperty("Pcru")]
    public virtual ICollection<PcrcancelledDetail> PcrcancelledDetails { get; set; } = new List<PcrcancelledDetail>();
}
