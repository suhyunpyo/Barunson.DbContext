using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 프리미어 페이퍼 SNS
/// </summary>
public partial class S4_Premier_SNS
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    public int? sample_order_seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

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
    public string? comment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sns_div { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string contents_url { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string best_div { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string view_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
