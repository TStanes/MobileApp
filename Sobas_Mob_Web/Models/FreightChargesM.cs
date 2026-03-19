using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FreightChargesM")]
public partial class FreightChargesM
{
    [Key]
    [Column("FreightChargesUID")]
    public Guid FreightChargesUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    public double Frieght { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Createdby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("FreightChargesMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("FreightChargesMs")]
    public virtual ItemM ItemU { get; set; } = null!;
}
