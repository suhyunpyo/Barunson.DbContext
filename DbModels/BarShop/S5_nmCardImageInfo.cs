using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일청첩장
/// </summary>
[PrimaryKey("Order_Seq", "FileType", "FileIndex")]
public partial class S5_nmCardImageInfo
{
    [Key]
    public int Order_Seq { get; set; }

    [Key]
    public int FileType { get; set; }

    [Key]
    public short FileIndex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OrgFileName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    public double? imageSizeW { get; set; }

    public double? imageSizeH { get; set; }

    public short? imageRotation { get; set; }

    public double? imagePositionX { get; set; }

    public double? imagePositionY { get; set; }
}
