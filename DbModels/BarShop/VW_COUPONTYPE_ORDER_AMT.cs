using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_COUPONTYPE_ORDER_AMT
{
    [StringLength(6)]
    [Unicode(false)]
    public string Coupon_Type_Code { get; set; } = null!;

    public int Order_Seq { get; set; }

    public int? COUPON_AMT { get; set; }
}
