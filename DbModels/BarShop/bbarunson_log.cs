using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 빠른손 로그
/// </summary>
public partial class bbarunson_log
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// 구분
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string gubun { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? key_idx { get; set; }

    /// <summary>
    /// 작업 쿼리문
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string? act_sql { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
