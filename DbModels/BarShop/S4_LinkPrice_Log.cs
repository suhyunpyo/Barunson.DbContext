using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_LinkPrice_Log
{
    [StringLength(100)]
    [Unicode(false)]
    public string LPINFO { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string YYYYMMDD { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string HHMISS { get; set; } = null!;

    public int order_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int order_count { get; set; }

    public int settle_price { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? card_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? category_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string user_ip { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
