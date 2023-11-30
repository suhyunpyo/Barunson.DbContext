using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 모바일초대장 계좌입력
/// </summary>
[PrimaryKey("target_id", "sort", "category")]
[MySqlCollation("utf8_unicode_ci")]
public partial class mobile_card_account
{
    /// <summary>
    /// 모바일청첩장 id
    /// </summary>
    [Key]
    [Column(TypeName = "int(10)")]
    public int target_id { get; set; }

    /// <summary>
    /// 정렬
    /// </summary>
    [Key]
    [Column(TypeName = "int(10)")]
    public int sort { get; set; }

    /// <summary>
    /// 신랑신부구분
    /// </summary>
    [Key]
    [Column(TypeName = "int(10)")]
    public int category { get; set; }

    /// <summary>
    /// 입금대상코드
    /// </summary>
    [StringLength(50)]
    public string? send_target_code { get; set; }

    /// <summary>
    /// 입금대상
    /// </summary>
    [StringLength(50)]
    public string? send_name { get; set; }

    /// <summary>
    /// 은행코드
    /// </summary>
    [StringLength(50)]
    public string? bank_code { get; set; }

    /// <summary>
    /// 계좌번호
    /// </summary>
    [StringLength(100)]
    public string? account_number { get; set; }

    /// <summary>
    /// 예금주
    /// </summary>
    [StringLength(100)]
    public string? account_holder { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
