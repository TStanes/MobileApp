using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DRCRCodeSelectLink")]
public partial class DrcrcodeSelectLink
{
    [Key]
    [Column("DRCRCodeSelectLinkUID")]
    public Guid DrcrcodeSelectLinkUid { get; set; }

    [Column("DrCrCodeSelectUID")]
    public Guid DrCrCodeSelectUid { get; set; }

    [Column("DRCodeUID")]
    public Guid? DrcodeUid { get; set; }

    [Column("CRCodeUID")]
    public Guid? CrcodeUid { get; set; }

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

    [ForeignKey("DrCrCodeSelectUid")]
    [InverseProperty("DrcrcodeSelectLinks")]
    public virtual DrCrCodeSelect DrCrCodeSelectU { get; set; } = null!;
}
