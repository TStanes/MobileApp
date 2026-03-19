using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ProcessChargesM")]
public partial class ProcessChargesM
{
    [Key]
    [Column("ProcessChargesUID")]
    public Guid ProcessChargesUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    public double ProcessCharges { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("ProcessChargesMs")]
    public virtual ItemM ItemU { get; set; } = null!;
}
