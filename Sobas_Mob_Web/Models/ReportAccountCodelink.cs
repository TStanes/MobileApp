using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ReportAccountCodelink")]
public partial class ReportAccountCodelink
{
    [Key]
    [Column("ReportID")]
    public int ReportId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ServiceCategory { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ServiceTaxCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CessOnServiceTaxCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HrEduCessCode { get; set; }

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
