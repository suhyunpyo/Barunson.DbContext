using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제휴 메인 페이지 관리
/// </summary>
public partial class bsmall_main_view
{
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// 제휴등급(A,B,C)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string jehu_grade { get; set; } = null!;

    /// <summary>
    /// 메인 메뉴 순서번호
    /// </summary>
    public int view_num { get; set; }

    /// <summary>
    /// 메인 메뉴구분
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? view_gb { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string updated_uid { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime updated_tmstmp { get; set; }
}
