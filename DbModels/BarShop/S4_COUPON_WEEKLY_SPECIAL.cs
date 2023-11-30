using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_COUPON_WEEKLY_SPECIAL
{
    [Key]
    public int SEQ { get; set; }

    public int? COUPON_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOWNLOAD_START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOWNLOAD_END_DATE { get; set; }

    public int? LIMIT_DOWNLOAD_QTY { get; set; }

    public int? REAL_DOWNLOAD_QTY { get; set; }

    public int? VIRTUAL_DOWNLOAD_QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
