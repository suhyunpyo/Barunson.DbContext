using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_UserQnA_Boton
{
    public int qa_iid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string member_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string e_mail { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string tel_no { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_mail_input { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? q_kind { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string q_title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string q_content { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isMail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSMS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSecret { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_upfile1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_upfile2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? a_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? a_dt { get; set; }

    [Column(TypeName = "text")]
    public string? a_content { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string a_stat { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_dt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? a_research1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? a_research2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? a_research_date { get; set; }
}
