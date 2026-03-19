using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SecondarySupplierM")]
public partial class SecondarySupplierM
{
    [Key]
    [Column("SecondarySupplierUID")]
    public Guid SecondarySupplierUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SupplierCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PinCode { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    public Guid CountryUid { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

    [Column("GSTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gstno { get; set; } = null!;

    [ForeignKey("CountryUid")]
    [InverseProperty("SecondarySupplierMs")]
    public virtual CountryM CountryU { get; set; } = null!;

    [InverseProperty("SecondarySupplierU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("SecondarySupplierU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [ForeignKey("StateUid")]
    [InverseProperty("SecondarySupplierMs")]
    public virtual StateM1 StateU { get; set; } = null!;
}
