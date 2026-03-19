using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TransactionTypePurposeLinkM")]
public partial class TransactionTypePurposeLinkM
{
    [Key]
    [Column("TransactionTypePurposeLinkUID")]
    public Guid TransactionTypePurposeLinkUid { get; set; }

    [StringLength(10)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column("TransactionTypePurposeTranUID")]
    public Guid TransactionTypePurposeTranUid { get; set; }

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
}
