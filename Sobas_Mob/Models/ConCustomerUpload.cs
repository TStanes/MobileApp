using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConCustomerUpload")]
public partial class ConCustomerUpload
{
    [StringLength(150)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("District Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? DistrictName { get; set; }

    [Column("State Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? StateName { get; set; }

    [Column("Branch Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pincode { get; set; }

    [Column("HQ Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HqCode { get; set; }

    [Column("Customer Code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerCode { get; set; }

    [Column("Customer Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [Column("Active/InActive")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActiveInActive { get; set; }

    [Column("Credit Limit", TypeName = "decimal(12, 4)")]
    public decimal? CreditLimit { get; set; }

    [Column("Expected Business", TypeName = "decimal(18, 3)")]
    public decimal? ExpectedBusiness { get; set; }

    [Column("Total Outstanding", TypeName = "decimal(18, 3)")]
    public decimal? TotalOutstanding { get; set; }

    [Column("Total Long Overdue", TypeName = "decimal(18, 3)")]
    public decimal? TotalLongOverdue { get; set; }

    [Column("Contact Phone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPhone { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Sales { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Collection { get; set; }
}
