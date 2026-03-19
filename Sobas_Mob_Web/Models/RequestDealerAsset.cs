using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("RequestDealerAsset")]
public partial class RequestDealerAsset
{
    [Key]
    [Column("DealerAssetUID")]
    public Guid DealerAssetUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Land { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Building { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MovableProperty { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Attachments1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attachment1FileName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Attachments2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attachment2FileName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Attachments3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attachment3FileName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Attachments4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attachment4FileName { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Attachments5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attachment5FileName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

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
}
