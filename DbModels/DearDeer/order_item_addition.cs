using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문부가상품
/// </summary>
[Index("addition_id", Name = "addition_id")]
[Index("addition_item_id", Name = "addition_item_id")]
[Index("order_id", Name = "order_id")]
[Index("order_item_id", Name = "order_item_id")]
[Index("order_item_no", Name = "order_item_no")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_item_addition
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
    /// orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(50)]
    public string order_no { get; set; } = null!;

    /// <summary>
    /// order_items.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    /// <summary>
    /// order_items.order_item_no
    /// </summary>
    [StringLength(50)]
    public string order_item_no { get; set; } = null!;

    /// <summary>
    /// invitation_card_addition.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int addition_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int addition_item_id { get; set; }

    /// <summary>
    /// invitation_card_addition.tadd_ype
    /// </summary>
    [StringLength(5)]
    public string addition_type { get; set; } = null!;

    /// <summary>
    /// 주문수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_cnt { get; set; }

    /// <summary>
    /// 전체수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int total_cnt { get; set; }

    [Column(TypeName = "int(11)")]
    public int start_no { get; set; }

    /// <summary>
    /// 추가금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int add_price { get; set; }

    [StringLength(50)]
    public string? groom_name { get; set; }

    [StringLength(50)]
    public string? bride_name { get; set; }

    [Column(TypeName = "text")]
    public string? memo { get; set; }

    /// <summary>
    /// 추가 입력값 value
    /// </summary>
    [Column(TypeName = "text")]
    public string? addition_value { get; set; }

    [StringLength(255)]
    public string? picture { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
