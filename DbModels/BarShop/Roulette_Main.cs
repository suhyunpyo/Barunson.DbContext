using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Roulette_Main
{
    [Key]
    public int rot_idx { get; set; }

    public int? rot_company_seq { get; set; }

    /// <summary>
    /// 룰렛이벤트명
    /// </summary>
    [StringLength(50)]
    public string? rot_title { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? rot_sDate { get; set; }

    /// <summary>
    /// 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? rot_Edate { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? rot_regdate { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public int? rot_Status { get; set; }

    /// <summary>
    /// 진행중회차
    /// </summary>
    public int? rot_ST { get; set; }

    /// <summary>
    /// 총 제품종류(8개 아이템이면:8)
    /// </summary>
    public int? last_ST { get; set; }

    /// <summary>
    /// 회차중 마지막 참여한 순번
    /// </summary>
    [StringLength(10)]
    public string? ing_ST { get; set; }

    /// <summary>
    /// 하단 덧글게시판 코드
    /// </summary>
    public int? comment_code { get; set; }

    /// <summary>
    /// 참여가능 최소금액 - 0원일때는 체크안함
    /// </summary>
    public int? rot_limit_price { get; set; }
}
