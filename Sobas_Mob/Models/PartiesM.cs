using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class PartiesM
{
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("Party_Cateogory")]
    [StringLength(150)]
    [Unicode(false)]
    public string PartyCateogory { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("State_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Pincode { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("Key_Person")]
    [StringLength(50)]
    [Unicode(false)]
    public string? KeyPerson { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Tngst { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Excise { get; set; } = null!;

    [Column("save")]
    public bool Save { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Initials { get; set; }

    [Column("S_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string SCode { get; set; } = null!;

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;
}
