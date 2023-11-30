using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_ORDER_DETAIL
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? product_order_id { get; set; }

    public int order_id { get; set; }

    public short seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? user_title { get; set; }

    public short prod_page { get; set; }

    public int item_count { get; set; }

    public int? item_price { get; set; }

    public int item_sale_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? item_option { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string product_state { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? process_state { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? express_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? delivery_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? print_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? p_packing_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? p_delivery_date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? thumbnail_url { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isput { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string iscomment { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isopen { get; set; } = null!;
}
