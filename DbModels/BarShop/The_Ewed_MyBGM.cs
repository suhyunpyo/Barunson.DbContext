using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class The_Ewed_MyBGM
{
    [StringLength(16)]
    [Unicode(false)]
    public string? member_id { get; set; }

    public int bgm_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string idx { get; set; } = null!;

    public byte? settle_status { get; set; }

    public int? settle_price { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string my_state { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_erp_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sales_Gubun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }
}
