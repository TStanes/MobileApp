using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("overdueDaysM")]
public partial class OverdueDaysM
{
    [Key]
    [Column("OverDueDaysMUID")]
    public Guid OverDueDaysMuid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CreditDays { get; set; }

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

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("OverdueDaysMs")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("OverdueDaysMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;
}
