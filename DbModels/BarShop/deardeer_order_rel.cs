using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class deardeer_order_rel
{
    [Key]
    public int order_seq { get; set; }

    public int? partner_shop_id { get; set; }
}
