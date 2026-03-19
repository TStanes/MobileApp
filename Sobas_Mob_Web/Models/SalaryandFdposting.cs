using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SalaryandFDPosting")]
public partial class SalaryandFdposting
{
    [Key]
    [Column("SalaryandFDPostingUID")]
    public Guid SalaryandFdpostingUid { get; set; }

    [Column("HeaderID")]
    public int HeaderId { get; set; }

    [StringLength(10)]
    public string BranchCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [Column("DetailID")]
    public int DetailId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VoucherDate { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CreditAmt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Purpose { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? HeaderDetail { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? LineDetail { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [Column("VoucherDetailUID")]
    public Guid? VoucherDetailUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [Column("Dr_BranchCode")]
    [StringLength(10)]
    public string? DrBranchCode { get; set; }

    [Column("Dr_DepartmentCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? DrDepartmentCode { get; set; }

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
