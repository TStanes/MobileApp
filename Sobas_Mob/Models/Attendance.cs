using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Attendance")]
public partial class Attendance
{
    [Column("FLAGNUMBER", TypeName = "decimal(18, 0)")]
    public decimal? Flagnumber { get; set; }

    [Column("FLAGNO")]
    [StringLength(100)]
    public string? Flagno { get; set; }

    [Column("FLAG")]
    [StringLength(50)]
    public string? Flag { get; set; }

    [Column("S_LFNO")]
    public int? SLfno { get; set; }

    [Column("S_CERT")]
    [StringLength(50)]
    public string? SCert { get; set; }

    [Column("S_HNAME")]
    [StringLength(100)]
    public string? SHname { get; set; }

    [Column("S_INIT")]
    [StringLength(5)]
    public string? SInit { get; set; }

    [Column("S_PRFX")]
    [StringLength(5)]
    public string? SPrfx { get; set; }

    [Column("S_FIL1")]
    [StringLength(3)]
    public string? SFil1 { get; set; }

    [Column("S_WNAM")]
    [StringLength(50)]
    public string? SWnam { get; set; }

    [Column("S_FNAM")]
    [StringLength(40)]
    public string? SFnam { get; set; }

    [Column("S_OCCU")]
    [StringLength(25)]
    public string? SOccu { get; set; }

    [Column("S_ADD1")]
    [StringLength(100)]
    public string? SAdd1 { get; set; }

    [Column("S_ADD2")]
    [StringLength(100)]
    public string? SAdd2 { get; set; }

    [Column("S_ADD3")]
    [StringLength(100)]
    public string? SAdd3 { get; set; }

    [Column("S_ADD4")]
    [StringLength(100)]
    public string? SAdd4 { get; set; }

    [Column("S_JHL1")]
    [StringLength(40)]
    public string? SJhl1 { get; set; }

    [Column("S_JHL2")]
    [StringLength(40)]
    public string? SJhl2 { get; set; }

    [Column("S_SHRN")]
    public double? SShrn { get; set; }

    [Column("S_DNO")]
    [StringLength(50)]
    public string? SDno { get; set; }

    [Column("S_ITCOD")]
    [StringLength(50)]
    public string? SItcod { get; set; }

    [Column("S_DIV")]
    [StringLength(50)]
    public string? SDiv { get; set; }

    [Column("S_CATE")]
    public double? SCate { get; set; }

    [Column("S_PAN1")]
    [StringLength(30)]
    public string? SPan1 { get; set; }

    [Column("S_PAN2")]
    [StringLength(25)]
    public string? SPan2 { get; set; }

    [Column("S_BON")]
    public double? SBon { get; set; }

    [Column("S_SPLT")]
    public double? SSplt { get; set; }

    [Column("S_APNO")]
    public double? SApno { get; set; }

    [Column("S_PBRN")]
    public double? SPbrn { get; set; }

    [Column("S_RIGTS")]
    public double? SRigts { get; set; }

    [Column("S_EFLG")]
    [StringLength(1)]
    public string? SEflg { get; set; }

    [Column("S_LSHN")]
    public double? SLshn { get; set; }

    [Column("S_OLD")]
    public double? SOld { get; set; }

    [Column("S_NEW")]
    public double? SNew { get; set; }

    [Column("S_DFR")]
    public double? SDfr { get; set; }

    [Column("S_DTO")]
    public double? SDto { get; set; }

    [Column("PINCODE")]
    [StringLength(7)]
    public string? Pincode { get; set; }

    [Column("SNAME")]
    [StringLength(40)]
    public string? Sname { get; set; }

    [Column("S_PRM")]
    [StringLength(1)]
    public string? SPrm { get; set; }

    [Column("S_FLG")]
    [StringLength(1)]
    public string? SFlg { get; set; }

    [Column("proxy1")]
    [StringLength(50)]
    public string? Proxy1 { get; set; }

    [Column("proxy2")]
    [StringLength(50)]
    public string? Proxy2 { get; set; }

    [Column("s_shar")]
    [StringLength(1)]
    public string? SShar { get; set; }

    [Column("type")]
    [StringLength(1)]
    public string? Type { get; set; }

    [Column("attendance")]
    public bool Attendance1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProxyDate { get; set; }
}
