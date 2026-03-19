using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StockPointDealerMapping")]
public partial class StockPointDealerMapping
{
    [Key]
    [Column("StockPointDealermappingUID")]
    public Guid StockPointDealermappingUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

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

    [ForeignKey("BranchUid")]
    [InverseProperty("StockPointDealerMappings")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("PartyUid")]
    [InverseProperty("StockPointDealerMappings")]
    public virtual PartyM PartyU { get; set; } = null!;
}
