using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class ewed_miniCD_INFO
{
    public int card_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CATE_L_CODE { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? CATE_S_CODE { get; set; }

    public int? CARD_NO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CARD_NAME { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CARD_TITLE { get; set; } = null!;

    public int CARD_PRICE { get; set; }

    public int? CARD_SALE_PRICE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CARD_INDATE { get; set; }

    public int? USE_CNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isFull { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wd_width { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wd_height { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? wd_size { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? wd_bgcolor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_SWF { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_S { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_SHAPE { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CARD_COMPOSITION { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CARD_FEATURE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CARD_EtcMsg { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? CARD_DESCRIPTION { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBest { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNew { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDisplay { get; set; }

    public int? Display_order { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? visit_use_yn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? attend_use_yn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? miniCD_use_yn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? auto_yn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? swf_type { get; set; }
}
