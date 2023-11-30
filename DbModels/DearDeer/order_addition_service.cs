using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문 서비스 정보
/// </summary>
[PrimaryKey("order_id", "service_type")]
public partial class order_addition_service
{
    /// <summary>
    /// 주문ID
    /// </summary>
    [Key]
    [Column(TypeName = "int(10)")]
    public int order_id { get; set; }

    /// <summary>
    /// 서비스구분
    /// </summary>
    [Key]
    [StringLength(20)]
    [MySqlCollation("utf8_unicode_ci")]
    public string service_type { get; set; } = null!;

    /// <summary>
    /// 수량
    /// </summary>
    [Column(TypeName = "int(10)")]
    public int qty { get; set; }

    /// <summary>
    /// 서비스 단가
    /// </summary>
    [Column(TypeName = "int(10)")]
    public int service_unit_price { get; set; }

    /// <summary>
    /// 서비스 금액
    /// </summary>
    [Column(TypeName = "int(10)")]
    public int service_price { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime created_at { get; set; }
}
