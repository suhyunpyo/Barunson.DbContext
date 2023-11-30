using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 뉴스기사
/// </summary>
public partial class S2_News
{
    [Key]
    public int seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? category { get; set; }

    public int? company_seq { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? medium_name { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? url_taget { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? URL_TARGET_BLANK_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isdp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? temp1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? temp2 { get; set; }

    [Column(TypeName = "ntext")]
    public string? contents { get; set; }

    public int? viewcnt { get; set; }
}
