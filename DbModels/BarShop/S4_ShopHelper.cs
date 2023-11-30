using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_ShopHelper
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    public int card_seq_1 { get; set; }

    public int card_seq_2 { get; set; }

    public int card_count_1 { get; set; }

    public int card_count_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string view_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
