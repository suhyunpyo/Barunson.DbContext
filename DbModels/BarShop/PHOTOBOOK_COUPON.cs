using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_COUPON
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    public int disrate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? coupon_msg { get; set; }

    /// <summary>
    /// 일회용쿠폰
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Isthrowaway { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string use_yn { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? site_msg { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? start_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? end_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }

    public int? min_price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }
}
