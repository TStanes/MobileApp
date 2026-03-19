using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PrintM")]
public partial class PrintM
{
    [Key]
    [Column("PrintUID")]
    public Guid PrintUid { get; set; }

    [StringLength(50)]
    public string CertificateNo { get; set; } = null!;

    [Column("DepartmentalDivisionUID")]
    public Guid DepartmentalDivisionUid { get; set; }

    [Column("ITSectionUID")]
    public Guid ItsectionUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [Column("QuarterUID")]
    public Guid QuarterUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    public int LastNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Status { get; set; } = null!;
}
