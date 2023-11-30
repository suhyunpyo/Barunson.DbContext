using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 유저-권한 릴레이션
/// </summary>
[Keyless]
[Index("role_id", Name = "users_roles_role_id_foreign")]
[Index("user_id", Name = "users_roles_user_id_foreign")]
[MySqlCollation("utf8_unicode_ci")]
public partial class users_roles
{
    [Column(TypeName = "int(10) unsigned")]
    public uint role_id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    [ForeignKey("role_id")]
    public virtual roles role { get; set; } = null!;

    [ForeignKey("user_id")]
    public virtual users user { get; set; } = null!;
}
