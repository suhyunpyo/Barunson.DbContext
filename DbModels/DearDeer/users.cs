using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 사용자관리
/// </summary>
[Index("created_at", Name = "created_at")]
[Index("user_id", Name = "user_id", IsUnique = true)]
[Index("user_id", "created_at", Name = "user_id_created_at")]
[Index("email", Name = "users_email_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class users
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(30)]
    public string name { get; set; } = null!;

    /// <summary>
    /// 테스트 계정
    /// </summary>
    [StringLength(1)]
    public string is_test { get; set; } = null!;

    /// <summary>
    /// 아이디
    /// </summary>
    [StringLength(50)]
    public string user_id { get; set; } = null!;

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(50)]
    public string email { get; set; } = null!;

    /// <summary>
    /// 휴대전화
    /// </summary>
    [StringLength(255)]
    public string phone { get; set; } = null!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(255)]
    public string password { get; set; } = null!;

    /// <summary>
    /// 가입채널
    /// </summary>
    [StringLength(20)]
    public string? join_channel { get; set; }

    /// <summary>
    /// 소셜 로그인 아이디
    /// </summary>
    [StringLength(30)]
    public string? social_key { get; set; }

    /// <summary>
    /// 제휴사 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    /// <summary>
    /// 제휴사 플래너명
    /// </summary>
    [StringLength(50)]
    public string? partner_planner { get; set; }

    /// <summary>
    /// 나이
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? age { get; set; }

    /// <summary>
    /// 성별 - F: 여자, M: 남자
    /// </summary>
    [StringLength(1)]
    public string? gender { get; set; }

    [StringLength(100)]
    public string? remember_token { get; set; }

    /// <summary>
    /// 최종로그인
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? last_login { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 회원가입 예상 예식일자
    /// </summary>
    [StringLength(50)]
    public string event_date { get; set; } = null!;

    /// <summary>
    /// SMS 수신동의여부
    /// </summary>
    [StringLength(1)]
    public string chk_sms { get; set; } = null!;

    /// <summary>
    /// 이메일 수신동의여부
    /// </summary>
    [StringLength(1)]
    public string chk_mail { get; set; } = null!;

    /// <summary>
    /// 중복가입확인번호
    /// </summary>
    [StringLength(100)]
    public string? dupinfo { get; set; }

    /// <summary>
    /// 고유번호
    /// </summary>
    [StringLength(100)]
    public string? conninfo { get; set; }

    /// <summary>
    /// 생일
    /// </summary>
    [StringLength(10)]
    public string? birthday { get; set; }

    /// <summary>
    /// 생일구분
    /// </summary>
    [StringLength(1)]
    public string? birthday_type { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    [StringLength(255)]
    public string? tel { get; set; }

    /// <summary>
    /// 우편번호
    /// </summary>
    [StringLength(255)]
    public string? post { get; set; }

    /// <summary>
    /// 주소1
    /// </summary>
    [StringLength(255)]
    public string? addr1 { get; set; }

    /// <summary>
    /// 주소2
    /// </summary>
    [StringLength(255)]
    public string? addr2 { get; set; }

    /// <summary>
    /// 예식장구분
    /// </summary>
    [StringLength(1)]
    public string? hall_type { get; set; }

    /// <summary>
    /// 예식장
    /// </summary>
    [StringLength(100)]
    public string? hall { get; set; }

    [InverseProperty("user")]
    public virtual ICollection<push_subscriptions> push_subscriptions { get; } = new List<push_subscriptions>();
}
