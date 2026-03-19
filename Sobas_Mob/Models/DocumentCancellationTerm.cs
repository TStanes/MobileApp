using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class DocumentCancellationTerm
{
    [Column("DocumentCancellationTermsUID")]
    public Guid DocumentCancellationTermsUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DaysAllowedforCancellation { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string TermsandConditions { get; set; } = null!;

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
