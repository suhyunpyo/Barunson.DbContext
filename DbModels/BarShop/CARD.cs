using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// Old 카드 정보
/// </summary>
public partial class CARD
{
    [Key]
    public int CARD_SEQ { get; set; }

    /// <summary>
    /// 0:barunson,1:thecard
    /// </summary>
    public short? CARD_GROUP { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CARD_CATE { get; set; }

    public int? CARD_CATEGORY_SEQ { get; set; }

    /// <summary>
    /// 1:청첩장,2:감사장,3:초대장
    /// </summary>
    public byte? CARD_KIND { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CARD_DIV { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CARD_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CARD_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ERP_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NEW_CODE { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? CARD_KEYWORD { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CARD_KEYWORD_SRC { get; set; }

    public int CARD_PRICE_CUSTOMER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DISPLAY_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? JUMUN_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string B2B_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string RECOMEND_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? CARD_FPrint { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B11 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B12 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B13 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B14 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_B15 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_ORDER1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_ORDER2 { get; set; }

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

    public int PRINT_SIZE { get; set; }

    /// <summary>
    /// 0일 경우 단종상품
    /// </summary>
    public short? PRODUCE_YEAR { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRODUCE_PLACE { get; set; }

    public int? set_seq { get; set; }

    public int? SALES_RANKING { get; set; }

    [Column(TypeName = "text")]
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
    public string? online_yes_or_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NEW_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsEnvInsert { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSBaesong { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsFPrint { get; set; }

    /// <summary>
    /// 청첩장에서 0 일때는 재고갯수 관리해 줄것.
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? ISHAVE { get; set; }

    public int? ISHAVE_NUM { get; set; }

    /// <summary>
    /// 0:속지없음,1:붙이기,2:끼우기,3:금사
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? ISInPaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsHandMade { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsFreehandmade { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsFreeEmbo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsEmbo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsInitial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOsiGaro { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSilk { get; set; }

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
    public string? IsHanji { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSelfEdit { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsColorInpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSpecialThank { get; set; }

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

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOBDisplay { get; set; }

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

    public int? acc_seq2 { get; set; }

    public int? place_seq { get; set; }

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

    /// <summary>
    /// 포토청첩장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is1003 { get; set; }

    /// <summary>
    /// 이니셜청첩장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is1004 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is1005 { get; set; }

    /// <summary>
    /// 사용자 이미지1 업로딩 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsUsrimg1 { get; set; }

    /// <summary>
    /// 사용자 이미지2 업로딩 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsUsrimg2 { get; set; }

    /// <summary>
    /// 사용자 이미지3 업로딩 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsUsrimg3 { get; set; }

    /// <summary>
    /// 사용자 코멘트 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsUsrComment { get; set; }

    /// <summary>
    /// 초특가 청첩장 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is1009 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is200 { get; set; }

    /// <summary>
    /// 개업인사,초대장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is400 { get; set; }

    /// <summary>
    /// 회갑,고희,돌
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is300 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is3001 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Is500 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ADMIN_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ADMIN_MEMO { get; set; }

    public double? CARD_MARKET_PRICE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isModern { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSweet { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isRomantic { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isStylish { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isTrendy { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isElegant { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isTie { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPearl { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPress { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isWinitial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isHologram { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isButterfly { get; set; }

    /// <summary>
    /// 월간 판매순위, 아침에 SP가 정보 update시
    /// </summary>
    public short? BestRangking { get; set; }

    /// <summary>
    /// 카드형태  1: 가로형, 2:세로형, 3:정사각형
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Card_Shape { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReInputDate { get; set; }

    /// <summary>
    /// 세일청첩장 (티아라카드)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Is1006 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrt { get; set; }
}
