using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class VoucherSchemeDetail
{
    [Key]
    [Column("VoucherSchemeDetailsUID")]
    public Guid VoucherSchemeDetailsUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

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

    [ForeignKey("InventoryTransListUid")]
    [InverseProperty("VoucherSchemeDetails")]
    public virtual InventoryTransList InventoryTransListU { get; set; } = null!;

    [ForeignKey("VoucherHeaderUid")]
    [InverseProperty("VoucherSchemeDetails")]
    public virtual VoucherHeader VoucherHeaderU { get; set; } = null!;
}
