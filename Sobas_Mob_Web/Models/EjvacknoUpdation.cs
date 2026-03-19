using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("EJVAcknoUpdation")]
public partial class EjvacknoUpdation
{
    [Key]
    [Column("EJVAcknowledgeUpdationUID")]
    public Guid EjvacknowledgeUpdationUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [Column("QuarterUID")]
    public Guid QuarterUid { get; set; }

    [StringLength(50)]
    public string AcknowledgementNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AcknowledgmentDt { get; set; }

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
