using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드 추가판 날짜 정보
/// </summary>
[Keyless]
public partial class custom_order_plistAddD
{
    public int pid { get; set; }

    /// <summary>
    /// 예식 년
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? event_year { get; set; }

    /// <summary>
    /// 예식 월
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? event_month { get; set; }

    /// <summary>
    /// 예식 일
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? event_day { get; set; }

    /// <summary>
    /// 예식 요일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? event_weekname { get; set; }

    /// <summary>
    /// 음력표기 여부
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? lunar_yes_or_no { get; set; }

    /// <summary>
    /// 음력일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? lunar_event_date { get; set; }

    /// <summary>
    /// 예식 오전/오후/낮 표기
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? event_ampm { get; set; }

    /// <summary>
    /// 예식 시
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? event_hour { get; set; }

    /// <summary>
    /// 예식 분
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? event_minute { get; set; }

    /// <summary>
    /// 예식장 이름
    /// </summary>
    [StringLength(200)]
    public string? wedd_name { get; set; }

    /// <summary>
    /// 예식장소
    /// </summary>
    [StringLength(200)]
    public string? wedd_place { get; set; }

    /// <summary>
    /// 예식장 주소
    /// </summary>
    [StringLength(1000)]
    public string? wedd_addr { get; set; }

    /// <summary>
    /// 예식장 전화번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_phone { get; set; }

    /// <summary>
    /// 바른손 예식장 키값
    /// </summary>
    public int? wedd_idx { get; set; }

    /// <summary>
    /// 바른손 약도 키값
    /// </summary>
    public int? wedd_imgidx { get; set; }

    /// <summary>
    /// AI 약도 아이디
    /// </summary>
    public int? map_id { get; set; }

    /// <summary>
    /// AI 교통편 아이디
    /// </summary>
    public int? traffic_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? map_trans_method { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? map_uploadfile { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotMapPrint { get; set; }

    /// <summary>
    /// 도로명주소
    /// </summary>
    [StringLength(1000)]
    public string? wedd_road_Addr { get; set; }

    /// <summary>
    /// 0:둘다선택, 1:둘다선택안함, 2:지번주소만, 3:도로명주소만
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? addr_gb { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AddrDirectInd { get; set; }
}
