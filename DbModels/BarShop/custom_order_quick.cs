using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_quick
{
    [Key]
    public int id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    public int? company_seq { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? order_seq { get; set; }

    public int quick_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sender_code { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? receiver_address { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? quick_reason { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? quick_type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? quick_dept { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? quick_driver_no { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
