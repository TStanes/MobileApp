using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EDChargesM")]
public partial class EdchargesM
{
    [Key]
    [Column("EdChargesUID")]
    public Guid EdChargesUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("ED")]
    public double Ed { get; set; }

    public double Cess { get; set; }

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
    [InverseProperty("EdchargesMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("EdchargesMs")]
    public virtual ItemM ItemU { get; set; } = null!;
}
