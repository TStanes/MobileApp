using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[PrimaryKey("BranchUid", "TransactiontypesUid", "FinYr", "DivisionUid")]
public partial class InventoryTransRequestSlNo
{
    [Key]
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Key]
    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Key]
    public int FinYr { get; set; }

    public int LastNo { get; set; }

    [Key]
    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }
}
