using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class RecTotalO
{
    [Column("principlename")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Principlename { get; set; }

    [Column("branchcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [Column("branchname")]
    [StringLength(150)]
    [Unicode(false)]
    public string Branchname { get; set; } = null!;

    [Column("partycode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [Column("partyname")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyname { get; set; } = null!;

    [Column("statedesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Statedesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os0to30Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os31to60Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os61to90Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os91to120Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os121to150Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os151to180Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OsAbove180Days { get; set; }

    [Column("CAG", TypeName = "decimal(38, 3)")]
    public decimal? Cag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RecOsState { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RecOsDvn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProcessMon { get; set; }

    [Column("RecDPName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RecDpname { get; set; }
}
