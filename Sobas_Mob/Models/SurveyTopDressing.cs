using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SurveyTopDressing")]
public partial class SurveyTopDressing
{
    [Key]
    [Column("SurveyTopDressingUID")]
    public Guid SurveyTopDressingUid { get; set; }

    [Column("SurveyQuestionnareUID")]
    public Guid SurveyQuestionnareUid { get; set; }

    [StringLength(150)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [StringLength(150)]
    public string? DealersName { get; set; }

    [StringLength(50)]
    public string? Purchase { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
