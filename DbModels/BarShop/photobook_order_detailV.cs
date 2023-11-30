using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class photobook_order_detailV
{
    public int order_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? product_order_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    public short prod_page { get; set; }

    public int item_count { get; set; }

    public int item_sale_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? item_option { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? thumbnail_url { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? prod_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cover_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? coating_yn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? prod_cate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string cover_style { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? makecom_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? prod_size { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? delivery_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? p_delivery_date { get; set; }
}
