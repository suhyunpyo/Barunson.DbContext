using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// OLD 카드 할인율 정보
/// </summary>
[Keyless]
public partial class CARD_DISCOUNT_RATE
{
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string card_Group { get; set; } = null!;

    public byte company { get; set; }

    /// <summary>
    /// I:카드 개별 할인율,P:가격대별 할인율
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    /// <summary>
    /// disrate_type=P 일때 카드 가격,I일때는 카드 키값
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string card_kind { get; set; } = null!;

    public int card_price { get; set; }

    /// <summary>
    /// 이상
    /// </summary>
    public short min_count { get; set; }

    /// <summary>
    /// 미만
    /// </summary>
    public short max_count { get; set; }

    /// <summary>
    /// 할인율
    /// </summary>
    public double discount_rate { get; set; }
}
