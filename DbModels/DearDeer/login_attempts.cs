using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 로그인 정보
/// </summary>
[Index("login_ip", Name = "idx_login_ip")]
[Index("user_id", Name = "login_attempts_user_id_foreign")]
[MySqlCollation("utf8_unicode_ci")]
public partial class login_attempts
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    [StringLength(15)]
    public string login_ip { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime login_time { get; set; }
}
