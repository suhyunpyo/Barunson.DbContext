using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 웨딩홀 약도이미지
/// </summary>
public partial class WeddingHall_Image
{
    [Key]
    public int seq { get; set; }

    public int WeddImg_IDX { get; set; }

    public int Wedd_IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? imgFolder { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ImgName { get; set; } = null!;

    public short? imgWidth { get; set; }

    public short? imgHeight { get; set; }

    public int? lsort { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_Date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCorel { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isR { get; set; }

    public int? sort { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColor { get; set; }
}
