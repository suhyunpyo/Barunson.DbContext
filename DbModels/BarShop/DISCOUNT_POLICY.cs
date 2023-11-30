using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할인율 관리
/// </summary>
public partial class DISCOUNT_POLICY
{
    [Key]
    public int DISCOUNT_SEQ { get; set; }

    public int? MIN_PRICE { get; set; }

    public int? MAX_PRICE { get; set; }

    public int? MIN_COUNT { get; set; }

    public int? MAX_COUNT { get; set; }

    public double? DISCOUNT_RATE { get; set; }

    public int CARD_CATEGORY_SEQ { get; set; }

    [ForeignKey("CARD_CATEGORY_SEQ")]
    [InverseProperty("DISCOUNT_POLICY")]
    public virtual CARD_CATEGORY CARD_CATEGORY_SEQNavigation { get; set; } = null!;
}
