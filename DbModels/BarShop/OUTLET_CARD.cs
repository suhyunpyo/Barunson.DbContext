using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class OUTLET_CARD
{
    public int CARD_SEQ { get; set; }

    public short? CARD_GROUP { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CARD_CATE { get; set; }

    public int? CARD_CATEGORY_SEQ { get; set; }

    public byte? CARD_KIND { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CARD_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ERP_CODE { get; set; }

    public int CARD_PRICE_CUSTOMER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DISPLAY_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string B2B_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string RECOMEND_YES_OR_NO { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CARD_IMG_S { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_XS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_MS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_M6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B9 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B10 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CARD_PAPER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CARD_SIZE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_OSI { get; set; }

    public short? COMPANY { get; set; }

    public short? PRODUCE_YEAR { get; set; }

    public int? set_seq { get; set; }

    public int? SALES_RANKING { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? CARD_DESCRIPTION { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGIST_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LAST_UPDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CARD_ENVELOPE { get; set; }

    public int? CARD_PRICE { get; set; }

    public double? CARD_SRC_PRICE { get; set; }

    public double? CARD_BRANCH_PRICE { get; set; }

    public double? CARD_ONLINE_BRANCH_PRICE { get; set; }

    public double? CARD_B2B_PRICE { get; set; }

    public double? CARD_DISCOUNT_RATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CARD_IMG_D { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISRATE_TYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BEST_YES_OR_NO { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BEST_STR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ONLINE_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NEW_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISHAVE { get; set; }

    public int? ISHAVE_NUM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISInPaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsHandMade { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsGold { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsRibon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsFlower { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsHeart { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsWonang { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsYu { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSample { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOffDisplay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOffBest { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOffDDisplay { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Env_code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cont_code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? acc_code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? env_code_o { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cont_code_o { get; set; }

    public int? acc_seq { get; set; }

    public int? env_seq { get; set; }

    public int? cont_seq { get; set; }

    public int? cont_seq_b2b { get; set; }

    public int? env_seq_b2b { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is100 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1001 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1002 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1003 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1004 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1005 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1006 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1007 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1008 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1009 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is200 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is400 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is300 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ADMIN_ID { get; set; }

    public double? CARD_MARKET_PRICE { get; set; }
}
