using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("OneTimeAddress")]
public partial class OneTimeAddress
{
    [Key]
    [Column("OneTimeAddressUID")]
    public Guid OneTimeAddressUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToPartyName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BillToAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BillToCity { get; set; }

    [Column("BillToStateUID")]
    public Guid? BillToStateUid { get; set; }

    [Column("BillToCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BillToCst { get; set; }

    [Column("BillToLST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BillToLst { get; set; }

    [Column("BillToTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BillToTinno { get; set; }

    [Column("BillToDealerCategoryUID")]
    public Guid? BillToDealerCategoryUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToPartyName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ShipToAddress4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToCity { get; set; }

    [Column("ShipToStateUID")]
    public Guid? ShipToStateUid { get; set; }

    [Column("ShipToCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToCst { get; set; }

    [Column("ShipToLST")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShipToLst { get; set; }

    [Column("ShipToTINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ShipToTinno { get; set; }

    [Column("ShipToDealerCategoryUID")]
    public Guid? ShipToDealerCategoryUid { get; set; }

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
}
