using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GroupHeadEntries_Delete")]
public partial class GroupHeadEntriesDelete
{
    [Column("AccountUID")]
    public Guid AccountUid { get; set; }
}
