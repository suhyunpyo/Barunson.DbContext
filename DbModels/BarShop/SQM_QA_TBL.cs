using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class SQM_QA_TBL
{
    [Key]
    public int QA_IID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int COMPANY_SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_tbl { get; set; }

    public int? order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string MEMBER_NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string E_MAIL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TEL_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isEmail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSMS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSecret { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Q_KIND { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Q_TITLE { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Q_CONTENT { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string A_ID { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? A_DT { get; set; }

    [Column(TypeName = "text")]
    public string A_CONTENT { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string A_STAT { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? a_research1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? a_research2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? a_research_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_upfile1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_upfile2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime REG_DT { get; set; }
}
