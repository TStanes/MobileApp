using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SurveyQuestionnare")]
public partial class SurveyQuestionnare
{
    [Key]
    [Column("SurveyQuestionnareUID")]
    public Guid SurveyQuestionnareUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("GrowersUID")]
    public Guid? GrowersUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? GrowersCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? GrowersName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SurName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Place { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Block { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Taluk { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [Column("EMail")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? WhatsAppNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAcres { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SoilType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TypeofFarming { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LandStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SoilAnalysis { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Crop { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NoofSeasonsunderCultivation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SourceofIrrigation { get; set; }

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
