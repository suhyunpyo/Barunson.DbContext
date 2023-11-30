using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_UserComment_etc
{
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    public int card_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? order_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [Column(TypeName = "text")]
    public string comment { get; set; } = null!;

    public int? score { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isDP { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? b_url { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? edit_date { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? device_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isbest { get; set; }
}
