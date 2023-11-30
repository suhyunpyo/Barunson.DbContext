using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드상세정보
/// </summary>
public partial class S2_CardDetail
{
    [Key]
    public int Card_Seq { get; set; }

    /// <summary>
    /// 봉투 SEQ
    /// </summary>
    public int? Env_Seq { get; set; }

    /// <summary>
    /// 봉투 그룹
    /// </summary>
    public int? Env_GroupSeq { get; set; }

    /// <summary>
    /// 내지
    /// </summary>
    public int? Inpaper_Seq { get; set; }

    /// <summary>
    /// 내지 그룹
    /// </summary>
    public int? Inpaper_GroupSeq { get; set; }

    /// <summary>
    /// 부속품1
    /// </summary>
    public int? Acc1_Seq { get; set; }

    /// <summary>
    /// 부속품1 그룹
    /// </summary>
    public int? Acc1_GroupSeq { get; set; }

    /// <summary>
    /// 부속품2
    /// </summary>
    public int? Acc2_Seq { get; set; }

    /// <summary>
    /// 부속품2 그룹
    /// </summary>
    public int? Acc2_GroupSeq { get; set; }

    /// <summary>
    /// 약도카드
    /// </summary>
    public int? MapCard_Seq { get; set; }

    /// <summary>
    /// 약도카드 그룹
    /// </summary>
    public int? MapCard_GroupSeq { get; set; }

    /// <summary>
    /// 인사말카드
    /// </summary>
    public int? GreetingCard_Seq { get; set; }

    /// <summary>
    /// 인사말카드 그룹
    /// </summary>
    public int? GreetingCard_GroupSeq { get; set; }

    /// <summary>
    /// 라이닝
    /// </summary>
    public int? Lining_Seq { get; set; }

    /// <summary>
    /// 라이닝 그룹
    /// </summary>
    public int? Lining_GroupSeq { get; set; }

    /// <summary>
    /// 제품설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? Card_Text { get; set; }

    /// <summary>
    /// 제품간략설명
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string? Card_Content { get; set; }

    /// <summary>
    /// 제품 키워드(위시/해피)
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string? Card_Keyword { get; set; }

    /// <summary>
    /// 사용안함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Card_Shape { get; set; }

    /// <summary>
    /// E0:접선없음, G1:가로1번,G2,G3 S1:세로1번, S2:세로2번,S3:세로3번,S4:세로4번
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Card_Folding { get; set; }

    /// <summary>
    /// 사용안함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Card_PrintMethod { get; set; }

    /// <summary>
    /// 카드 재질
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string? Card_Material { get; set; }

    /// <summary>
    /// 사용안함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Card_PrintOffice { get; set; }

    /// <summary>
    /// 최소 주문수량
    /// </summary>
    public short? Minimum_Count { get; set; }

    /// <summary>
    /// 추가주문시 최소 주문수량
    /// </summary>
    public short? AddMinimum_count { get; set; }

    /// <summary>
    /// 단위 주문수량
    /// </summary>
    [StringLength(10)]
    public string? Unit_Count { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? env_code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? inpaper_code { get; set; }

    /// <summary>
    /// 칼라내지
    /// </summary>
    public int? ColorInpaper_seq { get; set; }

    [StringLength(20)]
    public string? Acc_Type { get; set; }

    /// <summary>
    /// 프리미어페이퍼 제품설명
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string? Card_Text_Premier { get; set; }

    /// <summary>
    /// 씰카드
    /// </summary>
    public int? seal_seq { get; set; }

    /// <summary>
    /// 스티커
    /// </summary>
    public int Sticker_seq { get; set; }

    /// <summary>
    /// 스티커그룹
    /// </summary>
    public int Sticker_GroupSeq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CuttingLineType { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnvCharge { get; set; }

    public int? Flower_seq { get; set; }

    public int? Flower_GroupSeq { get; set; }

    public int? SealingSticker_seq { get; set; }

    public int? SealingSticker_GroupSeq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnvPrintMethod1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EnvPrintMethod2 { get; set; }

    public int? Ribonseq { get; set; }

    public int? RibonGroupSeq { get; set; }
}
