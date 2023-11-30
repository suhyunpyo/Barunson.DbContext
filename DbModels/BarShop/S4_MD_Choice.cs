using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 기획전 등록 제품
/// </summary>
[Index("MD_SEQ", Name = "NCI_S4_MD_Choice_MD_SEQ")]
public partial class S4_MD_Choice
{
    [Key]
    public int SEQ { get; set; }

    public int MD_SEQ { get; set; }

    public int SORTING_NUM { get; set; }

    public int? CARD_SEQ { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CARD_TEXT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MD_TITLE { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? MD_CONTENT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MD_DESC { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? IMGFILE_PATH { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CUSTOM_IMG { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LINK_URL { get; set; }

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

    [StringLength(1)]
    [Unicode(false)]
    public string? EVENT_OPEN_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SNS_SHARE_YORN { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SNS_SHARE_IMAGE_URL { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? ADMIN_ID { get; set; }

    public int? RECOM_NUM { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GRADE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GUBUN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BRAND_KIND { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SNS_TYPE { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? text_etc1 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? text_etc2 { get; set; }
}
