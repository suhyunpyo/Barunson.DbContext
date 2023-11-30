using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드코렐정보관리
/// </summary>
public partial class CARD_COREL
{
    public int id { get; set; }

    /// <summary>
    /// C:카드,I:내지, E:봉투
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string card_type { get; set; } = null!;

    /// <summary>
    /// 제품코드
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    /// <summary>
    /// 코렐 병합시 접선 방식
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isOsiGaro { get; set; } = null!;

    /// <summary>
    /// 코렐 병합시 역방향 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isReverse { get; set; } = null!;

    /// <summary>
    /// 코렐 병합시 밑단 공백 크기
    /// </summary>
    public int BlankSpace { get; set; }

    /// <summary>
    /// 코렐 병합시 용지 사이즈
    /// </summary>
    public int print_size { get; set; }

    /// <summary>
    /// 카드 앞면 배경 삽입 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isFBackColor { get; set; } = null!;

    /// <summary>
    /// 카드 속면 배경 삽입 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isBackColor { get; set; } = null!;

    /// <summary>
    /// 카드 속면 코렐 연동 방식(1일 경우 위치 지정)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isBackPoint { get; set; } = null!;

    /// <summary>
    /// 사용안함
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? env_num { get; set; }

    /// <summary>
    /// 카드가로크기
    /// </summary>
    public double? pageSizeW { get; set; }

    /// <summary>
    /// 카드세로크기
    /// </summary>
    public double? pageSizeH { get; set; }

    /// <summary>
    /// 최저높이
    /// </summary>
    public double? Hstandard { get; set; }

    /// <summary>
    /// 최고높이
    /// </summary>
    public double? HstandardMax { get; set; }

    /// <summary>
    /// 세로기준
    /// </summary>
    public double? Vstandard { get; set; }

    /// <summary>
    /// 왼쪽 기준선
    /// </summary>
    public double? Lstandard { get; set; }

    /// <summary>
    /// 오른쪽기준선
    /// </summary>
    public double? Rstandard { get; set; }

    /// <summary>
    /// 가이드라인(가로)
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? guideLineH { get; set; }

    /// <summary>
    /// 가이드라인(세로)
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? guideLineV { get; set; }

    /// <summary>
    /// 카드 가로접선
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? osiH { get; set; }

    /// <summary>
    /// 카드 세로접선
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? osiV { get; set; }

    /// <summary>
    /// 약도 삽입위치 X
    /// </summary>
    public double? mapPositionX { get; set; }

    /// <summary>
    /// 약도 삽입위치 Y
    /// </summary>
    public double? mapPositionY { get; set; }

    /// <summary>
    /// 약도 가로형 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsMapGaro { get; set; }

    /// <summary>
    /// 약도 카드 앞면 삽입 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string IsMapFront { get; set; } = null!;

    /// <summary>
    /// 사용안함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? IsExPreview { get; set; }

    /// <summary>
    /// 카드 앞면 인쇄 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string IsFPrint { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? IsInpaperBothSide { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsAlbaDown { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PrintGroup { get; set; }

    /// <summary>
    /// 카드 앞면 인쇄위치 X
    /// </summary>
    public double? FPrintX { get; set; }

    /// <summary>
    /// 카드 앞면 인쇄위치 Y
    /// </summary>
    public double? FPrintY { get; set; }

    /// <summary>
    /// 예식 일시 위치 X
    /// </summary>
    public double? WhenX { get; set; }

    /// <summary>
    /// 예식 일시 위치 Y
    /// </summary>
    public double? WhenY { get; set; }

    /// <summary>
    /// 예식 일시 폰트체
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? WhenFont { get; set; }

    /// <summary>
    /// 예식 일시 폰트 사이즈
    /// </summary>
    public short? WhenFontSize { get; set; }

    public double? WhereX { get; set; }

    /// <summary>
    /// 예식 장소 인쇄위치 Y
    /// </summary>
    public double? WhereY { get; set; }

    /// <summary>
    /// 예식 장소 폰트체
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? WhereFont { get; set; }

    /// <summary>
    /// 예식 장소 폰트 사이즈
    /// </summary>
    public short? WhereFontSize { get; set; }

    /// <summary>
    /// 신랑,신부 인쇄위치 X
    /// </summary>
    public double? GBX { get; set; }

    /// <summary>
    /// 신랑,신부 인쇄위치 Y
    /// </summary>
    public double? GBY { get; set; }

    /// <summary>
    /// 신랑,신부 폰트체
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? GBFont { get; set; }

    /// <summary>
    /// 신랑,신부 부모님 폰트체
    /// </summary>
    public short? GBFontSize1 { get; set; }

    /// <summary>
    /// 신랑,신부 서열 폰트체
    /// </summary>
    public short? GBFontSize2 { get; set; }

    /// <summary>
    /// 신랑,신부 폰트체
    /// </summary>
    public short? GBFontSize3 { get; set; }

    /// <summary>
    /// 인사말 인쇄위치 X
    /// </summary>
    public double? GreetX { get; set; }

    /// <summary>
    /// 인사말 인쇄위치 Y
    /// </summary>
    public double? GreetY { get; set; }

    /// <summary>
    /// 인사말 폰트체
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? GreetFont { get; set; }

    /// <summary>
    /// 인사말 폰트 사이즈
    /// </summary>
    public short? GreetFontSize { get; set; }

    public int? printSizeW { get; set; }

    public int? printSizeH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BOTH_SIDE_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INNER_WORK_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? WEPOD_YORN { get; set; }

    [StringLength(50)]
    public string? PAPER_SIZE_TYPE { get; set; }

    [StringLength(50)]
    public string? PAPER_NAME { get; set; }

    public int? PAPER_TICKNESS { get; set; }

    public int? PAPER_COMPOSITION { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CUTTING_LINE_DIRECTION { get; set; }

    /// <summary>
    /// 자동초안템플릿여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? AUTO_CHOAN_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AUTO_CHOAN_REGISTER_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorInpaper { get; set; }

    public double? EnvJacketSizeW { get; set; }

    public double? EnvJacketSizeH { get; set; }
}
