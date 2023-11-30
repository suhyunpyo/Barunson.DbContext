using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class photobook_order_detail_erp
{
    public int order_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? product_order_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    public int item_count { get; set; }

    public int? item_price { get; set; }

    public int item_sale_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? erp_code { get; set; }
}
