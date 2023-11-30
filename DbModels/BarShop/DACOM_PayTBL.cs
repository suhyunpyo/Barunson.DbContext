using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DACOM_PayTBL
{
    [Key]
    public long id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string pg_shopid { get; set; } = null!;

    public int order_seq { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? cal_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string settle_date { get; set; } = null!;

    public byte? settle_method { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string pay_date { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? status { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pay_info { get; set; }

    public int? settle_price { get; set; }
}
