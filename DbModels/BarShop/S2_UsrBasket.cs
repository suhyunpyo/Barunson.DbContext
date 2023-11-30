using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_UsrBasket
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    public int card_seq { get; set; }

    public int order_cnt { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str { get; set; }

    public int? option_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_type { get; set; }
}
