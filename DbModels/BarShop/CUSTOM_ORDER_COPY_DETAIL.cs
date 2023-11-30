using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 청첩장 지시서 내역
/// </summary>
public partial class CUSTOM_ORDER_COPY_DETAIL
{
    [Key]
    public long id { get; set; }

    public int order_seq { get; set; }

    /// <summary>
    /// 배송지 순서
    /// </summary>
    public byte delivery_seq { get; set; }

    /// <summary>
    /// 아이템 항목
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? item_type { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    public short item_seq { get; set; }

    /// <summary>
    /// 1:인쇄판제품,0:비인쇄판제품
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isPItem { get; set; } = null!;

    /// <summary>
    /// 항목명
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string item_title { get; set; } = null!;

    /// <summary>
    /// 코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string item_code { get; set; } = null!;

    /// <summary>
    /// 수량
    /// </summary>
    public short item_count { get; set; }

    /// <summary>
    /// 기타내용
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? etc1 { get; set; }

    /// <summary>
    /// 무게검증 수량
    /// </summary>
    public short? pack_count { get; set; }

    /// <summary>
    /// 무게검증 무게
    /// </summary>
    public int? pack_weight { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
