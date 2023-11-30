using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_passbook
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_tbl { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    public int? company_seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string sender_name { get; set; } = null!;

    public int send_price { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? send_msg { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string passbook_type_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }
}
