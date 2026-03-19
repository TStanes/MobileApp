using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EJVChallanUpdate")]
public partial class EjvchallanUpdate
{
    [Key]
    [Column("EJVChallanUID")]
    public Guid EjvchallanUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [StringLength(50)]
    public string Month { get; set; } = null!;

    [Column("CategoryUID")]
    public Guid? CategoryUid { get; set; }

    [Column("DepartmentalDivisionUID")]
    public Guid DepartmentalDivisionUid { get; set; }

    [Column("ITSectionUID")]
    public Guid ItsectionUid { get; set; }

    [StringLength(50)]
    public string ChallanNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ChallanDate { get; set; }

    [StringLength(50)]
    public string ChequeNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ChequeDt { get; set; }

    [Column("BSRCode")]
    [StringLength(50)]
    public string Bsrcode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateOfDeposit { get; set; }

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
