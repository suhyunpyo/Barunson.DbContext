using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CUSTOM_SAMPLE_ORDER_ITEM_deardup
{
    public int CARD_SEQ { get; set; }

    public int SAMPLE_ORDER_SEQ { get; set; }

    public int CARD_PRICE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isChu { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? md_recommend { get; set; }

    public int? sort { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? price_info { get; set; }
}
