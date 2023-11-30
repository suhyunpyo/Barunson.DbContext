using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 샘풀 주문 아이템
/// </summary>
[Index("product_id", Name = "product_id")]
[Index("sample_order_id", Name = "sample_order_id")]
[Index("sample_order_item_no", Name = "sample_order_item_no")]
[Index("sample_order_no", Name = "sample_order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class sample_order_items
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// sample_orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sample_order_id { get; set; }

    /// <summary>
    /// sample_orders.sample_order_no
    /// </summary>
    [StringLength(50)]
    public string sample_order_no { get; set; } = null!;

    /// <summary>
    /// 아이템번호
    /// </summary>
    [StringLength(50)]
    public string sample_order_item_no { get; set; } = null!;

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    /// <summary>
    /// products.code
    /// </summary>
    [StringLength(20)]
    public string? product_code { get; set; }

    /// <summary>
    /// custom_sample_order.sample_order_seq
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? barunson_samlpe_order_seq { get; set; }

    /// <summary>
    /// s2_card.card_seq
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? barunson_card_seq { get; set; }

    /// <summary>
    /// s2_card.card_code
    /// </summary>
    [StringLength(20)]
    public string? barunson_card_code { get; set; }

    /// <summary>
    /// 상품명
    /// </summary>
    [StringLength(50)]
    public string? product_name { get; set; }

    /// <summary>
    /// 주문수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_cnt { get; set; }

    [StringLength(255)]
    public string? requested { get; set; }

    /// <summary>
    /// 아이템타입
    /// </summary>
    [StringLength(10)]
    public string? item_type { get; set; }

    /// <summary>
    /// 가변샘플
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? is_changeable { get; set; }

    /// <summary>
    /// 레드 API 전송결과
    /// </summary>
    [Column(TypeName = "text")]
    public string? api_state_result { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
