using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SupplierWiseTDSPer")]
public partial class SupplierWiseTdsper
{
    [Key]
    [Column("SupplierWiseTDSPerUID")]
    public Guid SupplierWiseTdsperUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("AccountingPartyUID")]
    public Guid AccountingPartyUid { get; set; }

    [Column("TDSPer", TypeName = "decimal(18, 2)")]
    public decimal Tdsper { get; set; }

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
