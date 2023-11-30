using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 암호 재설정
/// </summary>
[Keyless]
[Index("email", Name = "password_resets_email_index")]
[Index("token", Name = "password_resets_token_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class password_resets
{
    [StringLength(255)]
    public string email { get; set; } = null!;

    [StringLength(255)]
    public string token { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
}
