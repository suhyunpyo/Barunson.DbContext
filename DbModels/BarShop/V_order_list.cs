using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class V_order_list
{
    [StringLength(2)]
    [Unicode(false)]
    public string? order_case { get; set; }

    [StringLength(20)]
    public string? order_type_str { get; set; }

    public int order_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_Date { get; set; }

    public int? status_seq { get; set; }

    [StringLength(20)]
    public string? status_seq_str { get; set; }

    public int? settle_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_resultinfo2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? delivery_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? delivery_com { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? delivery_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    public int? company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? member_email { get; set; }

    public int? unit_cnt { get; set; }
}
