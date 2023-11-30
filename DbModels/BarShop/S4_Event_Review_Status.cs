using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샘플이용후기 관리자답변
/// </summary>
public partial class S4_Event_Review_Status
{
    [Key]
    public int ERA_Idx { get; set; }

    public int ERA_ER_idx { get; set; }

    [StringLength(20)]
    public string? ERA_adminID { get; set; }

    /// <summary>
    /// 글상태 0:승인대기, 1:승인완료, 2:발급취소
    /// </summary>
    public int? ERA_Status { get; set; }

    /// <summary>
    /// 실쿠폰 전송여부 0:미전송, 1:전
    /// </summary>
    public int? ERA_Coupon_Status { get; set; }

    [StringLength(20)]
    public string? ERA_Coupon_Code { get; set; }

    [Column(TypeName = "ntext")]
    public string? ERA_Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ERA_Regdate { get; set; }

    [Column(TypeName = "ntext")]
    public string? ERA_Comment_Cancel { get; set; }
}
