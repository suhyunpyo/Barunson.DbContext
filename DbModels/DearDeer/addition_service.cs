using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 부가 서비스 정보
/// </summary>
public partial class addition_service
{
    /// <summary>
    /// 서비스구분
    /// </summary>
    [Key]
    [StringLength(20)]
    [MySqlCollation("utf8_unicode_ci")]
    public string service_type { get; set; } = null!;

    /// <summary>
    /// 서비스명
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? service_type_name { get; set; }

    /// <summary>
    /// 서비스비용
    /// </summary>
    [Column(TypeName = "int(10)")]
    public int service_cost { get; set; }

    /// <summary>
    /// 단가여부
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string is_unit { get; set; } = null!;

    /// <summary>
    /// 사용여부
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string is_use { get; set; } = null!;

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
