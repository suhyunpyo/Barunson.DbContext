using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 혼수폐쇄몰 회원이동log 테이블
/// </summary>
public partial class barunToclosed_log
{
    /// <summary>
    /// 회원아이디
    /// </summary>
    [Key]
    [StringLength(50)]
    public string uid { get; set; } = null!;

    /// <summary>
    /// 최초 이동시 진입사이트
    /// </summary>
    [StringLength(2)]
    public string site_div { get; set; } = null!;

    /// <summary>
    /// 이동횟수
    /// </summary>
    public int? linked_cnt { get; set; }

    /// <summary>
    /// PC/M구분 (P/M)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? device_gb { get; set; }

    /// <summary>
    /// 최초방문일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? created_tmstmp { get; set; }

    /// <summary>
    /// 최종방문일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? updated_tmstmp { get; set; }
}
