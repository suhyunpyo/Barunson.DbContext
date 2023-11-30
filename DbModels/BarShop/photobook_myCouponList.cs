using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class photobook_myCouponList
{
    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

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

    [StringLength(1)]
    [Unicode(false)]
    public string? Isthrowaway { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string use_yn { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? start_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? end_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
