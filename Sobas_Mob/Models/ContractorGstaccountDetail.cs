using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ContractorGSTAccountDetails")]
public partial class ContractorGstaccountDetail
{
    [Key]
    [Column("ContractorGSTAccountDetailsUID")]
    public Guid ContractorGstaccountDetailsUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("CGSTAccountUID")]
    public Guid CgstaccountUid { get; set; }

    [Column("CGSTAccountPer", TypeName = "decimal(18, 3)")]
    public decimal CgstaccountPer { get; set; }

    [Column("SGSTAccountUID")]
    public Guid SgstaccountUid { get; set; }

    [Column("SGSTAccountPer", TypeName = "decimal(18, 3)")]
    public decimal SgstaccountPer { get; set; }

    [Column("IGSTAccountUID")]
    public Guid IgstaccountUid { get; set; }

    [Column("GGSTAccountPer", TypeName = "decimal(18, 3)")]
    public decimal GgstaccountPer { get; set; }

    [Column("isActive")]
    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
