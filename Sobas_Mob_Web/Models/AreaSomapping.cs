using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("AreaSOMapping")]
public partial class AreaSomapping
{
    [Key]
    [Column("AreaSOUID")]
    public Guid AreaSouid { get; set; }

    [Column("AreaUID")]
    public Guid AreaUid { get; set; }

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [InverseProperty("AreaSou")]
    public virtual ICollection<AreaSoitemGroup> AreaSoitemGroups { get; set; } = new List<AreaSoitemGroup>();

    [InverseProperty("AreaSou")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("AreaSou")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [ForeignKey("Souid")]
    [InverseProperty("AreaSomappings")]
    public virtual SalesOfficerM Sou { get; set; } = null!;
}
