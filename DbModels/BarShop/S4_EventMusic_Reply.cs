using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이벤트 댓글
/// </summary>
public partial class S4_EventMusic_Reply
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    public int reg_num { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(4000)]
    public string? comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? var1 { get; set; }

    public int? card_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? inflow_route { get; set; }
}
