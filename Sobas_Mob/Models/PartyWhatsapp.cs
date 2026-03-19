using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("party_Whatsapp")]
public partial class PartyWhatsapp
{
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(10)]
    public string PartyCode { get; set; } = null!;

    [Column("partyName")]
    [StringLength(255)]
    public string? PartyName { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? MobNo { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? WhatsAppNo { get; set; }
}
