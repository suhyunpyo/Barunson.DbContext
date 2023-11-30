using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 회원탈퇴로그
/// </summary>
[Keyless]
public partial class users_leave_log
{
    /// <summary>
    /// ID
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string user_id { get; set; } = null!;

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
}
