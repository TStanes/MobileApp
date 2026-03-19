using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FinancialYearM")]
public partial class FinancialYearM
{
    [Key]
    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string CurrentYear { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string FromYear { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string ToYear { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string FromMonth { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string ToMonth { get; set; } = null!;

    [Column("FYear")]
    [StringLength(9)]
    [Unicode(false)]
    public string Fyear { get; set; } = null!;

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

    [InverseProperty("FinancialYearU")]
    public virtual ICollection<PartyCreditLimitM> PartyCreditLimitMs { get; set; } = new List<PartyCreditLimitM>();
}
