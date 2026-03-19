using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class DealerBankDetail
{
    [Key]
    [Column("DealerBankDetailsUID")]
    public Guid DealerBankDetailsUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BankLocation { get; set; } = null!;

    [Column("ACType")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actype { get; set; } = null!;

    [Column("ACNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string Acnumber { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("PartyUid")]
    [InverseProperty("DealerBankDetails")]
    public virtual PartyM PartyU { get; set; } = null!;
}
