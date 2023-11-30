using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 핫딜 이벤트
/// </summary>
[PrimaryKey("CARD_SEQ", "COMPANY_SEQ")]
public partial class EVT_HOTDEAL_STOCK
{
    [Key]
    public int COMPANY_SEQ { get; set; }

    [Key]
    public int CARD_SEQ { get; set; }

    public int LIMIT_CNT { get; set; }

    public int REMAIN_CNT { get; set; }
}
