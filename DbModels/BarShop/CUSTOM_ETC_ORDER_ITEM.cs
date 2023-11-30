using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 부가상품 주문상세정보
/// </summary>
[PrimaryKey("order_seq", "seq")]
public partial class CUSTOM_ETC_ORDER_ITEM
{
    public int card_seq { get; set; }

    [Key]
    public int order_seq { get; set; }

    [Key]
    public byte seq { get; set; }

    /// <summary>
    /// 주문수량
    /// </summary>
    public int order_count { get; set; }

    /// <summary>
    /// 상품소비자가격
    /// </summary>
    public int card_price { get; set; }

    /// <summary>
    /// 상품할인구매가
    /// </summary>
    public double card_sale_price { get; set; }

    /// <summary>
    /// W:청첩장 테이블,E:etc 테이블
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string order_tbl { get; set; } = null!;

    /// <summary>
    /// 시즌카드의 경우 카드교체여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isChange { get; set; } = null!;

    /// <summary>
    /// 제품선택옵션
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? card_opt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SampleBook_ID { get; set; }

    public byte? SampleBook_Status { get; set; }
}
