using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

[Keyless]
public partial class VW_User_QNA
{
    public int QNA_ID { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    public int? ORDER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EMAIL { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TITLE { get; set; } = null!;

    [Column(TypeName = "text")]
    public string CONTENT { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? PHONE_NUMBER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string UPFILE_1 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REGIST_DATETIME { get; set; }

    [Column(TypeName = "text")]
    public string? ANSWER_CONTENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ANSWER_DATETIME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ADMIN_NAME { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ADMIN_UPFILE1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string STAT { get; set; } = null!;
}
