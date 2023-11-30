using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 송장번호관리
/// </summary>
[Index("invoice_no", Name = "cj_invoice_numbers_invoice_no_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class cj_invoice_numbers
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(14)]
    public string invoice_no { get; set; } = null!;

    /// <summary>
    /// T: 사용함, F: 사용안함
    /// </summary>
    [StringLength(1)]
    public string is_used { get; set; } = null!;

    /// <summary>
    /// orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(21)]
    public string? order_no { get; set; }

    /// <summary>
    /// 주소정제API CLSFCD
    /// </summary>
    [StringLength(30)]
    public string? dlvClsfCd { get; set; }

    /// <summary>
    /// 주소정제 API SUBCLSFCD
    /// </summary>
    [StringLength(30)]
    public string? dlvSubClsfCd { get; set; }

    /// <summary>
    /// 주소정제API p_clldlvbranshortnm
    /// </summary>
    [StringLength(30)]
    public string? dlvPreArrBranShortNm { get; set; }

    /// <summary>
    /// 주소정제API p_clldlvempnm
    /// </summary>
    [StringLength(30)]
    public string? dlvPreArrEmpNickNm { get; set; }

    /// <summary>
    /// 주소정제API p_clldlvempnicknm
    /// </summary>
    [StringLength(30)]
    public string? dlvPreArrEmpNm { get; set; }

    /// <summary>
    /// 주소정제API p_clsfaddr
    /// </summary>
    [StringLength(30)]
    public string? rcvrEtcAddr { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 집하지시:01, 집하처리:11, 미집하:12, 간선상차:41, 간선하차:42, 배송출발:82, 미배달:84, 배송완료:91
    /// </summary>
    [StringLength(2)]
    public string CRG_ST { get; set; } = null!;

    /// <summary>
    /// INVOICE_PDF_PATH
    /// </summary>
    [StringLength(60)]
    public string? pdf_path { get; set; }
}
