using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("COSAEPostingStatus")]
public partial class CosaepostingStatus
{
    [Key]
    [Column("COSAEStatusUID")]
    public Guid CosaestatusUid { get; set; }

    public int PostedMonth { get; set; }

    public int PostedYear { get; set; }
}
