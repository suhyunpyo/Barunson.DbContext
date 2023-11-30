using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 바른손몰 메인 페이지 카드 관리
/// </summary>
public partial class BSMALL_MAIN_PRODUCT
{
    [Key]
    public int SEQ { get; set; }

    public int MD_SEQ { get; set; }

    /// <summary>
    /// 등급(A/B/C)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string GRADE { get; set; } = null!;

    /// <summary>
    /// BC:브랜드컬렉션 , B:BEST , N:NEW , S:SALE
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? GUBUN { get; set; }

    /// <summary>
    /// BrandCollection일 경우 사용.
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? BRAND_KIND { get; set; }

    public int SORTING_NUM { get; set; }

    public int? CARD_SEQ { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IMGFILE_PATH { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CUSTOM_IMG { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LINK_URL { get; set; }

    /// <summary>
    /// 새창사용여부
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? LINK_TARGET { get; set; }

    public int CLICK_COUNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string VIEW_DIV { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string JEHU_VIEW_DIV { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CREATED_DATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CREATED_UID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATED_DATE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? UPDATED_UID { get; set; }
}
