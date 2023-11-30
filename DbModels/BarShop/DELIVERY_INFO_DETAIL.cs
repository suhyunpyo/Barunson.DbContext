using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 배송정보상세
/// </summary>
public partial class DELIVERY_INFO_DETAIL
{
    [Key]
    public int ID { get; set; }

    public int order_seq { get; set; }

    /// <summary>
    /// delivery_info.id
    /// </summary>
    public int delivery_id { get; set; }

    /// <summary>
    /// C:카드,E:봉투,O:기타
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string item_type { get; set; } = null!;

    /// <summary>
    /// 판 이름 또는 제품명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? item_title { get; set; }

    /// <summary>
    /// item_type=P:custom_order_plist.id / item_type=O:custom_order_item.id
    /// </summary>
    public int item_id { get; set; }

    /// <summary>
    /// 수량
    /// </summary>
    public int item_count { get; set; }
}
