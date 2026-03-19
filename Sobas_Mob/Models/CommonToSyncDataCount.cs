using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("CommonToSyncDataCount")]
public partial class CommonToSyncDataCount
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(10)]
    public string BranchCode { get; set; } = null!;

    [StringLength(100)]
    public string BranchName { get; set; } = null!;

    [Column("HOITCount", TypeName = "numeric(18, 0)")]
    public decimal Hoitcount { get; set; }

    [Column("HOITLCount", TypeName = "numeric(18, 0)")]
    public decimal Hoitlcount { get; set; }

    [Column("HOITECount", TypeName = "numeric(18, 0)")]
    public decimal Hoitecount { get; set; }

    [Column("HOITLECount", TypeName = "numeric(18, 0)")]
    public decimal Hoitlecount { get; set; }

    [Column("HOVHCount", TypeName = "numeric(18, 0)")]
    public decimal Hovhcount { get; set; }

    [Column("HOVDCount", TypeName = "numeric(18, 0)")]
    public decimal Hovdcount { get; set; }

    [Column("HOVHECount", TypeName = "numeric(18, 0)")]
    public decimal Hovhecount { get; set; }

    [Column("HOVDECount", TypeName = "numeric(18, 0)")]
    public decimal Hovdecount { get; set; }

    [Column("HOVMCount", TypeName = "numeric(18, 0)")]
    public decimal Hovmcount { get; set; }

    [Column("DBNAME")]
    [StringLength(100)]
    public string Dbname { get; set; } = null!;

    [Column("COUNTMONTH", TypeName = "numeric(18, 0)")]
    public decimal Countmonth { get; set; }

    [Column("COUNTYEAR", TypeName = "numeric(18, 0)")]
    public decimal Countyear { get; set; }

    [Column("CREATEDDATE", TypeName = "datetime")]
    public DateTime Createddate { get; set; }
}
