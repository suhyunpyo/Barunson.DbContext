using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class photobook_prod_price
{
    [StringLength(50)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? makecom_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? prod_name { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? prod_cate2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? prod_size { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    public int prod_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? disrate_type { get; set; }

    public short? fix_disrate { get; set; }

    public int src_price { get; set; }

    public short prod_option { get; set; }

    public int add_price { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? mc_prod_name { get; set; }

    public short? p { get; set; }
}
