using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 고객센터
/// </summary>
[Index("order_no", Name = "order_no")]
[Index("user_id", Name = "user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class contact_contents
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 작성자id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? product_id { get; set; }

    /// <summary>
    /// S2_UserQnA.qa_iid / C07 : preview_opinion.bbs_seq
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? barunson_seq { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// 작성자 이름
    /// </summary>
    [StringLength(20)]
    public string? user_name { get; set; }

    /// <summary>
    /// 코멘트 타입
    /// </summary>
    [StringLength(3)]
    public string? type { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(255)]
    public string subject { get; set; } = null!;

    /// <summary>
    /// 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(255)]
    public string? password { get; set; }

    /// <summary>
    /// 첨부파일
    /// </summary>
    [StringLength(255)]
    public string? attached { get; set; }

    /// <summary>
    /// 확인여부
    /// </summary>
    [Column("checked", TypeName = "tinyint(4)")]
    public sbyte? _checked { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
