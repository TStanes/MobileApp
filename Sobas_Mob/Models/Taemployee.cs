using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TAEmployees")]
public partial class Taemployee
{
    public int? Employeeid { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [Column("in_rolls")]
    public bool InRolls { get; set; }

    [Column("Category_grp")]
    [StringLength(5)]
    public string? CategoryGrp { get; set; }

    [Column("scale")]
    public int? Scale { get; set; }

    [StringLength(50)]
    public string? FatherName { get; set; }

    [Column("categorycode")]
    public int? Categorycode { get; set; }

    [Column("DESIGNATION")]
    [StringLength(50)]
    public string? Designation { get; set; }

    [Column("PF_No")]
    public int? PfNo { get; set; }

    [Column("Branch_code")]
    [StringLength(4)]
    public string? BranchCode { get; set; }

    [Column("CON_DATE", TypeName = "datetime")]
    public DateTime? ConDate { get; set; }

    [Column("consolidated")]
    public bool Consolidated { get; set; }

    [Column("category_status")]
    [StringLength(50)]
    public string? CategoryStatus { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(6)]
    public string? Sex { get; set; }

    [StringLength(255)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(7)]
    public string? PostalCode { get; set; }

    [StringLength(30)]
    public string? EmrgcyContactPhone { get; set; }

    public int? Dept { get; set; }

    [Column("Date_of_joining", TypeName = "datetime")]
    public DateTime? DateOfJoining { get; set; }

    [Column("inc_code")]
    public int? IncCode { get; set; }

    [Column("Date_of_Birth", TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [Column("Blood Group")]
    [StringLength(15)]
    public string? BloodGroup { get; set; }

    [Column("inc_month", TypeName = "datetime")]
    public DateTime? IncMonth { get; set; }

    [Column("next_increment", TypeName = "datetime")]
    public DateTime? NextIncrement { get; set; }

    [Column("retirement_date", TypeName = "datetime")]
    public DateTime? RetirementDate { get; set; }

    public int? Modepay { get; set; }

    [Column("Bank_A\\c_No")]
    [StringLength(50)]
    public string? BankACNo { get; set; }

    [Column("Bank_Code")]
    public int? BankCode { get; set; }

    [Column("PF_Appli")]
    public bool PfAppli { get; set; }

    [Column("PF_Contribution_per")]
    public double? PfContributionPer { get; set; }

    [Column("ESI_No")]
    [StringLength(10)]
    public string? EsiNo { get; set; }

    [Column("ESI_Appli")]
    public bool EsiAppli { get; set; }

    [Column("save")]
    public bool Save { get; set; }

    [Column("Service_ledger_code")]
    [StringLength(10)]
    public string? ServiceLedgerCode { get; set; }

    [Column("sales_imp")]
    public double? SalesImp { get; set; }

    [Column("Lic_Policy_no")]
    [StringLength(50)]
    public string? LicPolicyNo { get; set; }

    [Column("pf_break")]
    public bool PfBreak { get; set; }

    [Column("Emp_Leavin_dt", TypeName = "datetime")]
    public DateTime? EmpLeavinDt { get; set; }

    [Column("PANNO")]
    [StringLength(10)]
    public string? Panno { get; set; }

    [Column("NEWDIV")]
    [StringLength(50)]
    public string? Newdiv { get; set; }

    [Column("NEWDIV2")]
    [StringLength(50)]
    public string? Newdiv2 { get; set; }

    [Column("OldService_ledger_code")]
    [StringLength(10)]
    public string? OldServiceLedgerCode { get; set; }

    [StringLength(50)]
    public string? DivisionCode { get; set; }

    [StringLength(50)]
    public string? DivisionName { get; set; }

    [Column("UAN")]
    [StringLength(50)]
    public string? Uan { get; set; }

    [Column("EmailID")]
    [StringLength(100)]
    public string? EmailId { get; set; }

    [Column("officialEmail")]
    [StringLength(50)]
    public string? OfficialEmail { get; set; }

    [StringLength(100)]
    public string? BranchEmail { get; set; }

    [Column("AADHARNO")]
    [StringLength(50)]
    public string? Aadharno { get; set; }

    [StringLength(200)]
    public string? EducationQualification { get; set; }
}
