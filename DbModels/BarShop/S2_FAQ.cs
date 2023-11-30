using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_FAQ
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? writer { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    public int faq_div { get; set; }

    public int display_order { get; set; }

    public int viewcnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    public string? blank_ { get; set; }
}
