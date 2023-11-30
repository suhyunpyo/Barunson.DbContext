using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Branch_QA_Tbl
{
    public int QA_IID { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string MEMBER_NAME { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string E_MAIL { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string TEL_NO { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Q_KIND { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Q_TITLE { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string Q_CONTENT { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? A_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? A_DT { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? A_CONTENT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? A_STAT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DT { get; set; }
}
