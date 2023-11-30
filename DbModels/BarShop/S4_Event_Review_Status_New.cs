using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 샘플이용후기 관리자답변
/// </summary>
public partial class S4_Event_Review_Status_New
{
    [Key]
    public int ERA_Idx { get; set; }

    public int ERA_ER_idx { get; set; }

    [StringLength(20)]
    public string? ERA_adminID { get; set; }

    public int? ERA_Status { get; set; }

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
