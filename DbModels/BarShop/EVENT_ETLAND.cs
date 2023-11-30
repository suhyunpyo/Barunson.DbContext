using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_ETLAND
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? c_uid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? c_email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string c_name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? c_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string c_hphone { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? c_addr { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? c_weddingday { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? admin_memo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isUse { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
