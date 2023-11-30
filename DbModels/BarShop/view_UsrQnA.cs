using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_UsrQnA
{
    [StringLength(1)]
    [Unicode(false)]
    public string isS2 { get; set; } = null!;

    public int qa_iid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string company_name { get; set; } = null!;

    public int? order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CARD_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string e_mail { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? tel_no { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Q_kind { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Q_title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Q_content { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string A_stat { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? a_dt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_dt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string a_research1 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string a_research2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? a_research_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? a_id { get; set; }
}
