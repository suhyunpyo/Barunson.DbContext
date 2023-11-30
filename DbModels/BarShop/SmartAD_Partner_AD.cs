using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 광고업체가 등록한 광고정보
/// </summary>
public partial class SmartAD_Partner_AD
{
    [Key]
    public int AD_SEQ { get; set; }

    public int PARTNER_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string AD_TYPE { get; set; } = null!;

    [StringLength(50)]
    public string? CONTENT1 { get; set; }

    [StringLength(50)]
    public string? CONTENT2 { get; set; }

    [StringLength(2000)]
    public string? CONTENT3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PROMOTION_TYPE { get; set; } = null!;

    [StringLength(20)]
    public string? COUPON_CODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [StringLength(2000)]
    public string? DIRECTION_MSG { get; set; }

    [StringLength(2000)]
    public string? CAUTION_MSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(100)]
    public string? UPD_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DISPLAY_YN { get; set; } = null!;

    public int? PRIORITY { get; set; }

    public int VIRTUAL_CNT { get; set; }
}
