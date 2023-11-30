using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("SiteCode", "Device", "Url", "QueryString")]
public partial class SEONonexistLog
{
    /// <summary>
    /// 고유번호
    /// </summary>
    public int Seq { get; set; }

    /// <summary>
    /// 사이트 구분코드 (SB:바른손카드, SS:프리미어페이퍼, B:바른손몰)
    /// </summary>
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    /// <summary>
    /// 유입경로 (P:PC, M:Mobile)
    /// </summary>
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string Device { get; set; } = null!;

    /// <summary>
    /// url 절대경로 / 로 시작해야함
    /// </summary>
    [Key]
    [StringLength(200)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    /// <summary>
    /// 넘겨진 querystring값
    /// </summary>
    [Key]
    [StringLength(200)]
    [Unicode(false)]
    public string QueryString { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}
