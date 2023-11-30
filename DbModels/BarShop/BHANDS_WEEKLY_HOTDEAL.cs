using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이벤트 핫딜기간 관리
/// </summary>
public partial class BHANDS_WEEKLY_HOTDEAL
{
    [Key]
    public int Seq { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string START_DT { get; set; } = null!;

    /// <summary>
    /// 종료일
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string END_DT { get; set; } = null!;

    public int? Card_seq { get; set; }

    /// <summary>
    /// 카드 정렬순서
    /// </summary>
    public int? W_NUM { get; set; }
}
