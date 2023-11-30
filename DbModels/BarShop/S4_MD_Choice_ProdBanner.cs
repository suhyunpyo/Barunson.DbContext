using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_MD_Choice_ProdBanner
{
    [Key]
    public int seq { get; set; }

    public int md_seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(100)]
    public string banner_title { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string target_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? item_type1_yorn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? item_type2_yorn { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? card_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pc_show_yorn { get; set; }

    [StringLength(255)]
    public string? pc_banner_image { get; set; }

    [StringLength(255)]
    public string? pc_move_url { get; set; }

    public int pc_click_count { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pc_new_win_yorn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? mo_show_yorn { get; set; }

    [StringLength(255)]
    public string? mo_banner_image { get; set; }

    [StringLength(255)]
    public string? mo_move_url { get; set; }

    public int mo_click_count { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? mo_new_win_yorn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? reg_admin_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mod_admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? banner_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string use_yorn { get; set; } = null!;

    public int sort { get; set; }

    /// <summary>
    /// Pc 배너 제목
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? pc_title { get; set; }

    /// <summary>
    /// Pc 배너 설명
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? pc_content { get; set; }

    /// <summary>
    /// Mobile 배너 제목
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? mo_title { get; set; }

    /// <summary>
    /// Mobile 배너 설명
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? mo_content { get; set; }
}
