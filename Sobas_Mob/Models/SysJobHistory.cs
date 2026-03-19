using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SysJobHistory")]
public partial class SysJobHistory
{
    [Column("instance_id")]
    public double? InstanceId { get; set; }

    [Column("job_id")]
    [StringLength(255)]
    public string? JobId { get; set; }

    [Column("step_id")]
    public double? StepId { get; set; }

    [Column("step_name")]
    [StringLength(255)]
    public string? StepName { get; set; }

    [Column("sql_message_id")]
    public double? SqlMessageId { get; set; }

    [Column("sql_severity")]
    public double? SqlSeverity { get; set; }

    [Column("message")]
    [Unicode(false)]
    public string? Message { get; set; }

    [Column("run_status")]
    public double? RunStatus { get; set; }

    [Column("run_date")]
    [StringLength(255)]
    public string? RunDate { get; set; }

    [Column("run_time")]
    public double? RunTime { get; set; }

    [Column("run_duration")]
    public double? RunDuration { get; set; }

    [Column("operator_id_emailed")]
    public double? OperatorIdEmailed { get; set; }

    [Column("operator_id_netsent")]
    public double? OperatorIdNetsent { get; set; }

    [Column("operator_id_paged")]
    public double? OperatorIdPaged { get; set; }

    [Column("retries_attempted")]
    public double? RetriesAttempted { get; set; }

    [Column("server")]
    [StringLength(255)]
    public string? Server { get; set; }
}
