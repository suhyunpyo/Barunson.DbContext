using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 배너관리
/// </summary>
public partial class BANNER_MST
{
    [Key]
    public int BANNER_SEQ { get; set; }

    public int? MD_SEQ { get; set; }

    public int? COMPANY_SEQ { get; set; }

    /// <summary>
    /// M메인배너_L왼쪽소배너_R오른쪽소배너_P팝업배너_N공지팝업
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? BANNER_TYPE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BANNER_TITLE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BANNER_IMAGE_URL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PAGE_LINK_URL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISPLAY_YN { get; set; }

    public int? SORT_NUM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? REG_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UPD_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPD_DATE { get; set; }
}
