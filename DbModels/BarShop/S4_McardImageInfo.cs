using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일청첩장
/// </summary>
[Keyless]
public partial class S4_McardImageInfo
{
    public int? Order_Seq { get; set; }

    public short? FileIndex { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    public short? imageRotation { get; set; }

    public double? imagePositionX { get; set; }

    public double? imagePositionY { get; set; }
}
