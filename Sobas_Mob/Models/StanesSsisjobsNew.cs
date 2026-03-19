using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("StanesSSISJobs_new")]
public partial class StanesSsisjobsNew
{
    [Column("Job_Id")]
    public Guid JobId { get; set; }

    [StringLength(50)]
    public string? JobName { get; set; }

    [StringLength(10)]
    public string? BranchCode { get; set; }

    [Column("IsBranchtoHO")]
    public int IsBranchtoHo { get; set; }
}
