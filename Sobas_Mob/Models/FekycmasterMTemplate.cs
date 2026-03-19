using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("FEKYCMasterM_Template")]
public partial class FekycmasterMTemplate
{
    [Column("ReqEmpUID")]
    public Guid ReqEmpUid { get; set; }

    [Column("ReqEmpID")]
    [StringLength(150)]
    public string ReqEmpId { get; set; } = null!;

    [Column("FieldEmpID")]
    [StringLength(150)]
    public string FieldEmpId { get; set; } = null!;

    [StringLength(150)]
    public string FieldEmpName { get; set; } = null!;

    [StringLength(150)]
    public string? FatherName { get; set; }

    [StringLength(10)]
    public string EmpGender { get; set; } = null!;

    [Column("EmpDOB", TypeName = "datetime")]
    public DateTime EmpDob { get; set; }

    [StringLength(150)]
    public string PresentAddress1 { get; set; } = null!;

    [StringLength(150)]
    public string? PresentAddress2 { get; set; }

    [StringLength(150)]
    public string? PresentAddress3 { get; set; }

    [StringLength(150)]
    public string? PresentCity { get; set; }

    [StringLength(150)]
    public string? PresentState { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PresentPinCode { get; set; }

    [StringLength(150)]
    public string PermanentAddress1 { get; set; } = null!;

    [StringLength(150)]
    public string? PermanentAddress2 { get; set; }

    [StringLength(150)]
    public string? PermanentAddress3 { get; set; }

    [StringLength(150)]
    public string? PermanentCity { get; set; }

    [StringLength(150)]
    public string? PermanentState { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? PermanentPinCode { get; set; }

    [StringLength(20)]
    public string? PhoneNo { get; set; }

    [StringLength(20)]
    public string MobileNo { get; set; } = null!;

    [Column("EmailID")]
    [StringLength(150)]
    public string EmailId { get; set; } = null!;

    [StringLength(150)]
    public string AccountBankName { get; set; } = null!;

    [StringLength(50)]
    public string BankAccountNo { get; set; } = null!;

    [StringLength(150)]
    public string? BankBranch { get; set; }

    [Column("BankIFSCCode")]
    [StringLength(50)]
    public string? BankIfsccode { get; set; }

    [StringLength(500)]
    public string? BankAddress { get; set; }

    [StringLength(50)]
    public string? EducationQualification { get; set; }

    [StringLength(50)]
    public string? AadhaarNo { get; set; }

    [StringLength(50)]
    public string? PanNo { get; set; }

    [StringLength(50)]
    public string? PassportNo { get; set; }

    [StringLength(50)]
    public string? VoterId { get; set; }

    [StringLength(50)]
    public string? RationCard { get; set; }

    [StringLength(50)]
    public string? DrivingLicense { get; set; }

    [StringLength(500)]
    public string? Att1 { get; set; }

    [StringLength(500)]
    public string? Att2 { get; set; }

    [StringLength(500)]
    public string? Att3 { get; set; }

    [Column("FEBranch")]
    public Guid Febranch { get; set; }

    [Column("FEDivision")]
    public Guid Fedivision { get; set; }

    [Column("FEStatus")]
    public Guid Festatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [Column("FERelievingDate")]
    [StringLength(50)]
    public string? FerelievingDate { get; set; }

    [Column("FERelievingReason")]
    [StringLength(50)]
    public string? FerelievingReason { get; set; }

    [StringLength(500)]
    public string? Remarks { get; set; }

    [StringLength(500)]
    public string? IsActive { get; set; }

    [StringLength(50)]
    public string? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
