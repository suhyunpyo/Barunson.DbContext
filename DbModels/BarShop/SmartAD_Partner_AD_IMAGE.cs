using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 광고업체가 등록한 광고이미지
/// </summary>
public partial class SmartAD_Partner_AD_IMAGE
{
    [Key]
    public int IMAGE_SEQ { get; set; }

    public int AD_SEQ { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string IMAGE_TYPE { get; set; } = null!;

    [StringLength(3000)]
    public string? IMG_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(100)]
    public string? UPD_ID { get; set; }
}
