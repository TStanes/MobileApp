using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BCEDenominationDetails")]
public partial class BcedenominationDetail
{
    [Key]
    [Column("BceDenominationUID")]
    public Guid BceDenominationUid { get; set; }

    [Column("BceReimbUID")]
    public Guid BceReimbUid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal DenominationValue { get; set; }

    public int DenominationQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
