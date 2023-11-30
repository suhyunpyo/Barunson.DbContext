using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Order_Settle
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string order_div { get; set; } = null!;

    public int? settle_price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? transaction_no { get; set; }

    public byte? result_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? result_msg { get; set; }

    public byte? payment_way { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? auth_no { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? company_code { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? auth_date { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? auth_time { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_no { get; set; }

    /// <summary>
    /// 1일 경우 데이콤 거래
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isdacom { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PGcancel_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? virReturn_date { get; set; }
}
