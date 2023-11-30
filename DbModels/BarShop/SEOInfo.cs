using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("RegDate", Name = "IX_SEOInfo_RegDate")]
[Index("SiteCode", "Device", "Url", "KeyValueString", Name = "IX_SEOInfo_SiteCode_Device_Url_KeyValueString", IsUnique = true)]
[Index("UseFlag", Name = "IX_SEOInfo_UseFlag")]
public partial class SEOInfo
{
    /// <summary>
    /// 고유번호
    /// </summary>
    [Key]
    public int SeoSeq { get; set; }

    /// <summary>
    /// 사이트 구분코드 (SB:바른손카드, SS:프리미어페이퍼, B:바른손몰)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string SiteCode { get; set; } = null!;

    /// <summary>
    /// 유입경로 (P:PC, M:Mobile)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string Device { get; set; } = null!;

    /// <summary>
    /// url 절대경로 / 로 시작해야함
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Url { get; set; } = null!;

    /// <summary>
    /// URL 메인 카테고리
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Category { get; set; }

    /// <summary>
    /// 웹에 표시할 Title명
    /// </summary>
    [StringLength(120)]
    [Unicode(false)]
    public string TitleName { get; set; } = null!;

    /// <summary>
    /// 웹페이지에 meta tag에 출력할 설명글
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? Description { get; set; }

    /// <summary>
    /// link 태그에 출력할 캐노니컬 url
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? CanonicalUri { get; set; }

    /// <summary>
    /// QueryString과 매칭할 파라메터 값
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? KeyValueString { get; set; }

    /// <summary>
    /// KeyValueString에 포함됨 파라메터 갯수
    /// </summary>
    public byte KeyCount { get; set; }

    /// <summary>
    /// 사용여부 (1:사용 0:미사용)
    /// </summary>
    public bool UseFlag { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AdminID { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdDate { get; set; }
}
