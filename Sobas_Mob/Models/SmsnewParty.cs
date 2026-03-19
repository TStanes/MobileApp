using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SMSNewParty")]
public partial class SmsnewParty
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Approveddate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    public int Flag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Att1 { get; set; } = null!;
}
