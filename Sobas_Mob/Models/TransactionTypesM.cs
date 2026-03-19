using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TransactionTypesM")]
public partial class TransactionTypesM
{
    [Key]
    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string UsedFor { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

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

    [InverseProperty("TransactionTypesU")]
    public virtual ICollection<DrCrCodeSelect> DrCrCodeSelects { get; set; } = new List<DrCrCodeSelect>();

    [InverseProperty("TransactiontypesU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("TransactiontypesU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("TransactiontypesU")]
    public virtual ICollection<LedgerTemplatesM> LedgerTemplatesMs { get; set; } = new List<LedgerTemplatesM>();

    [InverseProperty("TransactionTypeU")]
    public virtual ICollection<TransactionTypeConfiguration> TransactionTypeConfigurations { get; set; } = new List<TransactionTypeConfiguration>();

    [InverseProperty("TransactiontypesU")]
    public virtual ICollection<TransactionTypePurposeHeaderM> TransactionTypePurposeHeaderMs { get; set; } = new List<TransactionTypePurposeHeaderM>();
}
