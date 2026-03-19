using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemInterested")]
public partial class ItemInterested
{
    [Key]
    [Column("ItemInterestedUID")]
    public Guid ItemInterestedUid { get; set; }

    [Column("EnquiryMUID")]
    public Guid? EnquiryMuid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Qty { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Packing { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
    [InverseProperty("ItemInteresteds")]
    public virtual PartyM? PartyU { get; set; }
}
