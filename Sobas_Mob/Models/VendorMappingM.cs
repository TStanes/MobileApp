using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VendorMappingM")]
public partial class VendorMappingM
{
    [Key]
    [Column("VendorMappingUID")]
    public Guid VendorMappingUid { get; set; }

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column("CustomerUID")]
    public Guid CustomerUid { get; set; }

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

    [ForeignKey("CustomerUid")]
    [InverseProperty("VendorMappingMCustomerU")]
    public virtual PartyM CustomerU { get; set; } = null!;

    [ForeignKey("SupplierUid")]
    [InverseProperty("VendorMappingMSupplierU")]
    public virtual PartyM SupplierU { get; set; } = null!;
}
