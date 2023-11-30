using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드뉴스
/// </summary>
public partial class WeddingMagazine
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Kind { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Img_Url { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Link_Url { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? View_YN { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string contents { get; set; } = null!;

    public int View_Cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? SortingNum { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? List_View_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CateGory { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? LinkTarget { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Mo_Img_Url { get; set; }

    public int? Mo_View_Cnt { get; set; }
}
