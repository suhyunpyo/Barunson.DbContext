using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_COUPON_ADDON_CARD_SEQ
{
    [Key]
    public int SEQ { get; set; }

    public int? COUPON_SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    public int? SORTING_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
