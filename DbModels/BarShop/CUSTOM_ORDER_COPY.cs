using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 청첩장 지시서 검증내용
/// </summary>
[PrimaryKey("order_seq", "delivery_seq")]
public partial class CUSTOM_ORDER_COPY
{
    [Key]
    public int order_seq { get; set; }

    /// <summary>
    /// 배송지순서
    /// </summary>
    [Key]
    public byte delivery_seq { get; set; }

    /// <summary>
    /// 배송방법
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? delivery_method { get; set; }

    /// <summary>
    /// 제본처리
    /// </summary>
    [StringLength(150)]
    [Unicode(false)]
    public string? jebon_str { get; set; }

    /// <summary>
    /// 엠보인쇄
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? embo_str { get; set; }

    /// <summary>
    /// 특수인쇄
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? print_str { get; set; }

    /// <summary>
    /// 주의요망 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isRisk { get; set; } = null!;

    /// <summary>
    /// 퀵처리 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isQuick { get; set; } = null!;
}
