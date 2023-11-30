using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 관리자 유저 관리(사용안함)
/// </summary>
[Index("email", Name = "admin_users_email_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class admin_users
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? is_super_admin { get; set; }

    [Column(TypeName = "int(11)")]
    public int role_id { get; set; }

    [StringLength(255)]
    public string first_name { get; set; } = null!;

    [StringLength(255)]
    public string last_name { get; set; } = null!;

    [StringLength(255)]
    public string email { get; set; } = null!;

    [StringLength(255)]
    public string password { get; set; } = null!;

    [StringLength(100)]
    public string? remember_token { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
