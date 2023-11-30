using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 빠른손 오류 로그
/// </summary>
public partial class ERR_TBL
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// 에러 발생 관리 아이디
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? login_id { get; set; }

    /// <summary>
    /// 해당 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? err_desc { get; set; }

    /// <summary>
    /// 발생시각
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? err_time { get; set; }
}
