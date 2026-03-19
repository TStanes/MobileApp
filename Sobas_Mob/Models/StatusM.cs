using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StatusM")]
public partial class StatusM
{
    [Key]
    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

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

    [InverseProperty("StatusU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("StatusU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("StatusU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();

    [InverseProperty("StatusU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();
}
