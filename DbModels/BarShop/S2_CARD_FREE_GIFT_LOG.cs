using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// (받은)사은품로그
/// </summary>
public partial class S2_CARD_FREE_GIFT_LOG
{
    [Key]
    public int LOG_SEQ { get; set; }

    /// <summary>
    /// S2_CARD_FREE_GIFT.free_gift_seq
    /// </summary>
    public int? FREE_GIFT_SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    public int? ORDER_SEQ { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
