using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 업로드 이미지 관리
/// </summary>
[Index("deleted_at", Name = "idx_deleted")]
[Index("order_no", Name = "idx_order_no")]
[Index("sort_order", Name = "idx_sort_order")]
[Index("target", "target_id", Name = "target_target_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class uploaded_images
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// {table}
    /// </summary>
    [StringLength(20)]
    public string? target { get; set; }

    /// <summary>
    /// {table}.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint? target_id { get; set; }

    /// <summary>
    /// 업로드이미지
    /// </summary>
    [StringLength(150)]
    public string? origin { get; set; }

    /// <summary>
    /// 썸네일1
    /// </summary>
    [StringLength(150)]
    public string? thumb1 { get; set; }

    /// <summary>
    /// 썸네일2
    /// </summary>
    [StringLength(150)]
    public string? thumb2 { get; set; }

    /// <summary>
    /// 썸네일3
    /// </summary>
    [StringLength(150)]
    public string? thumb3 { get; set; }

    /// <summary>
    /// 썸네일4
    /// </summary>
    [StringLength(150)]
    public string? thumb4 { get; set; }

    /// <summary>
    /// 썸네일5
    /// </summary>
    [StringLength(150)]
    public string? thumb5 { get; set; }

    /// <summary>
    /// 노출 url
    /// </summary>
    [StringLength(150)]
    public string? link { get; set; }

    /// <summary>
    /// 주문번호-모바일청첩장에서사용
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(4000)]
    public string? desc { get; set; }

    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
