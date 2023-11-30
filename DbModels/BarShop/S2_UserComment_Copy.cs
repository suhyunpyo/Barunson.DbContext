using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_UserComment_Copy
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

    [StringLength(50)]
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

    public byte? score { get; set; }

    public int sym_cnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isDP { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string? best_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? best_month { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? best_week { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public byte? resch_color { get; set; }

    public byte? resch_bright { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? upimg { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? comm_div { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? b_url { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? edit_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EVENT_STATUS_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? upimg1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? upimg2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? upimg3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? upimg4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? upimg5 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? m_upimg1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? m_upimg2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? m_upimg3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? m_upimg4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? m_upimg5 { get; set; }
}
