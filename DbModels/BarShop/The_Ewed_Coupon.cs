using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Ewed_Coupon
{
    public int seq { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    public int? order_id { get; set; }

    /// <summary>
    /// (O:주문발행, S:스티커발행)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string iscoupon_kind { get; set; } = null!;

    /// <summary>
    /// (Y,N)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isuse_yn { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
