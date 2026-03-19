using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("query_stats")]
[Index("QueryHash", "QueryPlanHash", Name = "idx_query_hash")]
public partial class QueryStat
{
    [Column("sql_handle")]
    [MaxLength(64)]
    public byte[] SqlHandle { get; set; } = null!;

    [Column("statement_start_offset")]
    public int StatementStartOffset { get; set; }

    [Column("statement_end_offset")]
    public int StatementEndOffset { get; set; }

    [Column("plan_generation_num")]
    public long PlanGenerationNum { get; set; }

    [Column("plan_handle")]
    [MaxLength(64)]
    public byte[] PlanHandle { get; set; } = null!;

    [Column("creation_time", TypeName = "datetime")]
    public DateTime CreationTime { get; set; }

    [Column("last_execution_time", TypeName = "datetime")]
    public DateTime LastExecutionTime { get; set; }

    [Column("execution_count")]
    public long ExecutionCount { get; set; }

    [Column("total_worker_time")]
    public long TotalWorkerTime { get; set; }

    [Column("last_worker_time")]
    public long LastWorkerTime { get; set; }

    [Column("min_worker_time")]
    public long MinWorkerTime { get; set; }

    [Column("max_worker_time")]
    public long MaxWorkerTime { get; set; }

    [Column("total_physical_reads")]
    public long TotalPhysicalReads { get; set; }

    [Column("last_physical_reads")]
    public long LastPhysicalReads { get; set; }

    [Column("min_physical_reads")]
    public long MinPhysicalReads { get; set; }

    [Column("max_physical_reads")]
    public long MaxPhysicalReads { get; set; }

    [Column("total_logical_writes")]
    public long TotalLogicalWrites { get; set; }

    [Column("last_logical_writes")]
    public long LastLogicalWrites { get; set; }

    [Column("min_logical_writes")]
    public long MinLogicalWrites { get; set; }

    [Column("max_logical_writes")]
    public long MaxLogicalWrites { get; set; }

    [Column("total_logical_reads")]
    public long TotalLogicalReads { get; set; }

    [Column("last_logical_reads")]
    public long LastLogicalReads { get; set; }

    [Column("min_logical_reads")]
    public long MinLogicalReads { get; set; }

    [Column("max_logical_reads")]
    public long MaxLogicalReads { get; set; }

    [Column("total_clr_time")]
    public long TotalClrTime { get; set; }

    [Column("last_clr_time")]
    public long LastClrTime { get; set; }

    [Column("min_clr_time")]
    public long MinClrTime { get; set; }

    [Column("max_clr_time")]
    public long MaxClrTime { get; set; }

    [Column("total_elapsed_time")]
    public long TotalElapsedTime { get; set; }

    [Column("last_elapsed_time")]
    public long LastElapsedTime { get; set; }

    [Column("min_elapsed_time")]
    public long MinElapsedTime { get; set; }

    [Column("max_elapsed_time")]
    public long MaxElapsedTime { get; set; }

    [Column("query_hash")]
    [MaxLength(8)]
    public byte[] QueryHash { get; set; } = null!;

    [Column("query_plan_hash")]
    [MaxLength(8)]
    public byte[] QueryPlanHash { get; set; } = null!;

    [Column("text")]
    public string? Text { get; set; }

    [Column("dbid")]
    public short? Dbid { get; set; }

    [Column("objectid")]
    public int? Objectid { get; set; }

    [Column("number")]
    public short? Number { get; set; }

    [Column("encrypted")]
    public bool Encrypted { get; set; }

    [Column("query_plan", TypeName = "xml")]
    public string? QueryPlan { get; set; }

    [Column("collection_time", TypeName = "datetime")]
    public DateTime CollectionTime { get; set; }
}
