using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샤넬 이벤트
/// </summary>
[Keyless]
public partial class MD_GIFT_EVENT_CHANEL
{
    public int card_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string card_name { get; set; } = null!;

    public int TOTAL_CNT { get; set; }

    /// <summary>
    /// 잔여수
    /// </summary>
    public int REMAIN_CNT { get; set; }
}
