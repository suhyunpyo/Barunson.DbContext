using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 제휴몰 샵 관리자
/// </summary>
[Index("email", Name = "partner_users_email_unique", IsUnique = true)]
[Index("phone", Name = "partner_users_phone_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class partner_users
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// partner_shop.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    /// <summary>
    /// 유저 아이디
    /// </summary>
    [StringLength(255)]
    public string user_id { get; set; } = null!;

    /// <summary>
    /// 사용자 명
    /// </summary>
    [StringLength(255)]
    public string name { get; set; } = null!;

    /// <summary>
    /// 사용자 이메일
    /// </summary>
    [StringLength(255)]
    public string email { get; set; } = null!;

    /// <summary>
    /// 전화번호
    /// </summary>
    [StringLength(255)]
    public string phone { get; set; } = null!;

    /// <summary>
    /// 암호
    /// </summary>
    [StringLength(255)]
    public string password { get; set; } = null!;

    /// <summary>
    /// 리멤버
    /// </summary>
    [StringLength(100)]
    public string? remember_token { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
