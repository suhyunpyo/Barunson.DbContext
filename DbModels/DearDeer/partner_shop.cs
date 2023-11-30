using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 제휴몰
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class partner_shop
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 제휴사명
    /// </summary>
    [StringLength(30)]
    public string? partner_name { get; set; }

    /// <summary>
    /// 사업자번호
    /// </summary>
    [StringLength(30)]
    public string? business_number { get; set; }

    /// <summary>
    /// 제휴사주소1
    /// </summary>
    [StringLength(255)]
    public string? partner_addr1 { get; set; }

    /// <summary>
    /// 제휴사주소2
    /// </summary>
    [StringLength(255)]
    public string? partner_addr2 { get; set; }

    /// <summary>
    /// 과세유형
    /// </summary>
    [StringLength(1)]
    public string tax_type { get; set; } = null!;

    /// <summary>
    /// VAT (T:포함/F:별도)
    /// </summary>
    [StringLength(1)]
    public string vat_type { get; set; } = null!;

    /// <summary>
    /// 수수료율 사용여부 (T:사용/F:사용안함)
    /// </summary>
    [StringLength(1)]
    public string use_commission { get; set; } = null!;

    /// <summary>
    /// 수수료율(%)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int commission_rate { get; set; }

    /// <summary>
    /// 마감일
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? end_date { get; set; }

    /// <summary>
    /// 정산일
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? due_date { get; set; }

    /// <summary>
    /// coupons_id, 0 = 사용안함)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int coupon_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
