using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 사은품 주는 카드관리
/// </summary>
public partial class S2_CARD_FREE_GIFT_TARGET_CARD
{
    [Key]
    public int FREE_GIFT_TARGET_SEQ { get; set; }

    public int? FREE_GIFT_SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
