using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("EDMaster")]
public partial class Edmaster
{
    [Key]
    [Column("EDMasterUID")]
    public Guid EdmasterUid { get; set; }

    public DateOnly FromDate { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AbatmentPer { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 2)")]
    public decimal Edper { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 2)")]
    public decimal EdcessPer { get; set; }

    [Column("EDHrEduCessPer", TypeName = "decimal(18, 2)")]
    public decimal EdhrEduCessPer { get; set; }

    [Column("IsForMRP")]
    public bool IsForMrp { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("Edmasters")]
    public virtual ItemM ItemU { get; set; } = null!;
}
