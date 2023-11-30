using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_BASKET
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? prod_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_title { get; set; }

    public short prod_page { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? prod_order_id { get; set; }

    public int? prod_seq { get; set; }

    public int? prod_price { get; set; }

    public short? prod_disrate { get; set; }

    public int? prod_sale_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? disrate_type { get; set; }

    public short item_count { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? status { get; set; }

    public short? seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }
}
