using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드이벤트 관리
/// </summary>
public partial class tEvent
{
    [Key]
    public int EventIdx { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string EventNM { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EventGB { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string CatLCD { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string Contents { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string? ItemCD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ViewYN { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Banner { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertDT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? templateYN { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? templateUrl { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? PageWidth { get; set; }

    /// <summary>
    /// Y:내부 네비게이션 사용, N:내부 네비게이션 미사용
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? NaviYN { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MainImage { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? MainHtml { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? MainText { get; set; }

    /// <summary>
    /// 기본노출 Y:사용, N:미사용
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? projectYN { get; set; }

    /// <summary>
    /// P:타이틀 Bar 형식 일반형식, N:타이틀 Bar 형식 네비형식
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? TitleBarType { get; set; }

    public int? TopBannerType { get; set; }

    public int? MiddleBannerType { get; set; }

    public int? BottomBannerType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string FSEventYN { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image3 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image4 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image5 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Top6Image6 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL1 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL2 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL3 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL4 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL5 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Top6ImageURL6 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SnsYN { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? SnsImageURL { get; set; }
}
