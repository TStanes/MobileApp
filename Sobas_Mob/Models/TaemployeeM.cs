using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TAEmployeeM")]
[Index("EmployeeUid", Name = "_dta_index_TAEmployeeM_5_1576600905__K1_2_3_4")]
[Index("EmployeeUid", Name = "_dta_index_TAEmployeeM_5_1576600905__K1_3")]
public partial class TaemployeeM
{
    [Key]
    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(200)]
    public string EmployeeName { get; set; } = null!;

    [StringLength(200)]
    public string EmployeeDesignation { get; set; } = null!;

    [StringLength(10)]
    public string BranchCode { get; set; } = null!;

    [StringLength(10)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(50)]
    public string BankAccNo { get; set; } = null!;

    [StringLength(200)]
    public string InpaymentOf { get; set; } = null!;

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

    [StringLength(250)]
    public string? BankName { get; set; }

    [StringLength(500)]
    public string? BankAddress { get; set; }

    [Column("BankIFSCCode")]
    [StringLength(50)]
    public string? BankIfsccode { get; set; }

    public bool? ReqStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RetdDate { get; set; }

    [InverseProperty("EmployeeU")]
    public virtual ICollection<EmployeeAnnualLeaveM> EmployeeAnnualLeaveMs { get; set; } = new List<EmployeeAnnualLeaveM>();
}
