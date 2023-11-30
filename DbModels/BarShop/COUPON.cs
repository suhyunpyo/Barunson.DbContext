using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// old 쿠폰
/// </summary>
public partial class COUPON
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string code { get; set; } = null!;

    public int? order_seq { get; set; }

    public int discount_Value { get; set; }

    /// <summary>
    /// W:청첩장,E:e청첩장
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string use_type { get; set; } = null!;

    /// <summary>
    /// 1:제휴사 발행 쿠폰
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isJaehu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isUse { get; set; }

    public int? company_seq { get; set; }

    /// <summary>
    /// R:할인율, P:금액차감
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? discount_type { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? start_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? end_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUsable { get; set; }

    public int? seq_num { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tmp1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tmp2 { get; set; }
}
