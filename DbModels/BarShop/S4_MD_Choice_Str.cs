using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 기획전
/// </summary>
public partial class S4_MD_Choice_Str
{
    [Key]
    public int md_seq { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string md_text { get; set; } = null!;

    public int md_upper_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string choice_div { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? link_url { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? link_target { get; set; }

    public int company_seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int sorting_num { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string cardtitle_yn { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? customimg_yn { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? md_sub_text { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? md_image { get; set; }

    [Column(TypeName = "text")]
    public string? md_html { get; set; }
}
