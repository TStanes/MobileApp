using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ProductionQRCodeItemDetails")]
public partial class ProductionQrcodeItemDetail
{
    [Key]
    [Column("ProductionQRCodeItemDetailsUID")]
    public Guid ProductionQrcodeItemDetailsUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ManufacturedBy { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MarketedBy { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string RegistrationNo { get; set; } = null!;

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
    [InverseProperty("ProductionQrcodeItemDetails")]
    public virtual ItemM ItemU { get; set; } = null!;
}
