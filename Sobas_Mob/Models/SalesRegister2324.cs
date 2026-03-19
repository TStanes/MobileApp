using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalesRegister2324")]
public partial class SalesRegister2324
{
    [Column("branchstatecode")]
    public double? Branchstatecode { get; set; }

    [Column("branchstatedesc")]
    [StringLength(255)]
    public string? Branchstatedesc { get; set; }

    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? DivisionCode { get; set; }

    [StringLength(255)]
    public string? DivisionDesc { get; set; }

    [Column("docno")]
    [StringLength(255)]
    public string? Docno { get; set; }

    [Column("docdate", TypeName = "datetime")]
    public DateTime? Docdate { get; set; }

    public double? Mon { get; set; }

    public double? Yr { get; set; }

    [StringLength(255)]
    public string? Finyear { get; set; }

    [Column("SOCode")]
    public double? Socode { get; set; }

    [Column("SOName")]
    [StringLength(255)]
    public string? Soname { get; set; }

    [StringLength(255)]
    public string? ItemHead { get; set; }

    [StringLength(255)]
    public string? HeadItemDesc { get; set; }

    public double? Qty { get; set; }

    public double? SalesValue { get; set; }

    [StringLength(255)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(255)]
    public string? ItemSegmentDesc { get; set; }

    [StringLength(255)]
    public string? ItemGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemgroupDesc { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    [StringLength(255)]
    public string? AreaCode { get; set; }

    [StringLength(255)]
    public string? AreaDesc { get; set; }

    [Column("partycode")]
    [StringLength(255)]
    public string? Partycode { get; set; }

    [Column("partyname")]
    [StringLength(255)]
    public string? Partyname { get; set; }

    [Column("itemcode")]
    [StringLength(255)]
    public string? Itemcode { get; set; }

    [Column("itemdesc")]
    [StringLength(255)]
    public string? Itemdesc { get; set; }
}
