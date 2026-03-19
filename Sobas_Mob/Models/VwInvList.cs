using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwInvList
{
    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("Invoice_Ident")]
    [StringLength(150)]
    [Unicode(false)]
    public string InvoiceIdent { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("ST", TypeName = "decimal(18, 2)")]
    public decimal St { get; set; }

    [Column("STDesc")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Stdesc { get; set; }

    [Column("ED", TypeName = "decimal(18, 2)")]
    public decimal Ed { get; set; }

    [Column("EDDesc")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Eddesc { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CessonEd { get; set; }

    [Column("SC", TypeName = "decimal(18, 2)")]
    public decimal? Sc { get; set; }

    [Column("ST_AMT", TypeName = "decimal(18, 3)")]
    public decimal StAmt { get; set; }

    [Column("ED_AMT", TypeName = "decimal(18, 3)")]
    public decimal EdAmt { get; set; }

    [Column("SC_AMT", TypeName = "decimal(18, 3)")]
    public decimal? ScAmt { get; set; }

    [Column("CessonEDAmt", TypeName = "decimal(18, 3)")]
    public decimal CessonEdamt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherDiscount { get; set; }

    public int NoOfCase { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MfgDate { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column("Invoice_id", TypeName = "decimal(18, 0)")]
    public decimal InvoiceId { get; set; }

    [Column("TransID")]
    public Guid TransId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Igrp { get; set; } = null!;

    [Column("Commodity_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommodityCode { get; set; }

    [Column("Schedule_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleNo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Repdesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Segment { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Grp { get; set; } = null!;
}
