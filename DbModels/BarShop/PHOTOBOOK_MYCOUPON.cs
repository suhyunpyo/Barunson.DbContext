using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("uid", "coupon_code")]
public partial class PHOTOBOOK_MYCOUPON
{
    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
