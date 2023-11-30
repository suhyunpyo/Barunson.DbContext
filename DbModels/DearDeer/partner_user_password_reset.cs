using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 파트너 암호 재설정
/// </summary>
[Keyless]
[Index("email", Name = "partner_user_password_reset_email_index")]
[Index("token", Name = "partner_user_password_reset_token_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class partner_user_password_reset
{
    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(255)]
    public string email { get; set; } = null!;

    /// <summary>
    /// 토큰
    /// </summary>
    [StringLength(255)]
    public string token { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
}
