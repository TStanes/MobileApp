using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StockPointCommisionAccountMapping")]
public partial class StockPointCommisionAccountMapping
{
    [Key]
    [Column("StockPointCommisionAccountMappingUID")]
    public Guid StockPointCommisionAccountMappingUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

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

    [ForeignKey("AccountUid")]
    [InverseProperty("StockPointCommisionAccountMappings")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("StockPointCommisionAccountMappings")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;
}
