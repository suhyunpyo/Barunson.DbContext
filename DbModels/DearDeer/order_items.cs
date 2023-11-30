using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문-아이템
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_item_no", Name = "order_item_no")]
[Index("order_no", Name = "order_no")]
[Index("parent_id", Name = "parent_id")]
[Index("product_id", Name = "product_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_items
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(25)]
    public string order_no { get; set; } = null!;

    [StringLength(30)]
    public string order_item_no { get; set; } = null!;

    /// <summary>
    /// 레드주문번호
    /// </summary>
    [StringLength(30)]
    public string? red_order_item_no { get; set; }

    [Column(TypeName = "text")]
    public string? draft_link { get; set; }

    [Column(TypeName = "int(11)")]
    public int? indd_link { get; set; }

    [StringLength(3)]
    public string? draft_state { get; set; }

    [StringLength(3)]
    public string? printing_state { get; set; }

    [StringLength(1)]
    public string? is_draft { get; set; }

    [StringLength(1)]
    public string? is_create_file { get; set; }

    [StringLength(1)]
    public string? is_printing { get; set; }

    [StringLength(20)]
    public string item_type { get; set; } = null!;

    [StringLength(20)]
    public string? api_state_result { get; set; }

    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    [StringLength(20)]
    public string? product_code { get; set; }

    [StringLength(50)]
    public string? product_name { get; set; }

    [StringLength(20)]
    public string? order_item_code { get; set; }

    [Column(TypeName = "int(11)")]
    public int? barunson_order_seq { get; set; }

    /// <summary>
    /// 바른손 주문타입: base: 인쇄제품, etc: 완제품
    /// </summary>
    [StringLength(5)]
    public string barunson_order_type { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int? barunson_order_item_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? barunson_order_plist_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? barunson_order_plist_front_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? barunson_card_seq { get; set; }

    [StringLength(20)]
    public string? barunson_card_code { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    [Column(TypeName = "int(11) unsigned")]
    public uint? parent_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? qty { get; set; }

    [Column(TypeName = "int(11)")]
    public int? total_money { get; set; }

    [StringLength(1)]
    public string? draft_change { get; set; }

    [StringLength(10)]
    public string? status_red { get; set; }

    /// <summary>
    /// 완선된 상품 : 입고: T, 입고안됨: F
    /// </summary>
    [StringLength(1)]
    public string is_reciving { get; set; } = null!;

    /// <summary>
    /// 완선된 상품 입고시간
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? reciving_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
