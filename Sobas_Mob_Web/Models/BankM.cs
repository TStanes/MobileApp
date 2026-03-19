using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BankM")]
public partial class BankM
{
    [Key]
    [Column("BankUID")]
    public Guid BankUid { get; set; }

    [Column("BankID")]
    [StringLength(2)]
    [Unicode(false)]
    public string BankId { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Width { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Height { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string AccountNo { get; set; } = null!;
}
