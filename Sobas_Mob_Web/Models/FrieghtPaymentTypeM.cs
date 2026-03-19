using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FrieghtPaymentTypeM")]
public partial class FrieghtPaymentTypeM
{
    [Key]
    [Column("FrieghtPaymentTypeUID")]
    public Guid FrieghtPaymentTypeUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FrieghtPaymentCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FrieghtPaymentType { get; set; } = null!;

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

    [InverseProperty("FrieghtPaymentTypeU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("FrieghtPaymentTypeU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();
}
