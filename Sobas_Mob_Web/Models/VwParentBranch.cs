using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwParentBranch
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ParentBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ParentBranchName { get; set; } = null!;
}
