using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class V_order_list_v2
{
    [StringLength(2)]
    [Unicode(false)]
    public string? order_case { get; set; }

    public int order_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_Date { get; set; }

    public int? status_seq { get; set; }

    public int? settle_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(1000)]
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
    public string? member_id { get; set; }

    public int? company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? member_email { get; set; }

    public int? up_order_seq { get; set; }
}
