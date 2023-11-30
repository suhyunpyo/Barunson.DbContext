using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("order_seq", Name = "custom_order_agreement_Index_1")]
public partial class custom_order_agreement
{
    /// <summary>
    /// increment
    /// </summary>
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// custom_order.order_seq
    /// </summary>
    public int? order_seq { get; set; }

    /// <summary>
    /// 동의 타입 (africa, unicef)
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? agreement_type { get; set; }

    /// <summary>
    /// 동의여부 0, 1
    /// </summary>
    public int? is_agreemented { get; set; }

    /// <summary>
    /// 봉투 프린트 여부 0, 1
    /// </summary>
    public int? is_print { get; set; }

    /// <summary>
    /// 등록시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
