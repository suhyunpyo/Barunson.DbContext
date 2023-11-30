using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CARD_SAMPLE_FREE_GIFT
{
    [Key]
    public int FREE_GIFT_SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CARD_CODE { get; set; }

    /// <summary>
    /// 잔여수량
    /// </summary>
    public int? QTY { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ITEM_TYPE { get; set; }

    [StringLength(1000)]
    public string? FREE_GIFT_DESC { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    /// <summary>
    /// 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    /// <summary>
    /// 금액제한
    /// </summary>
    public int? LIMIT_ORDER_PRICE { get; set; }

    /// <summary>
    /// 수량제한
    /// </summary>
    public int? LIMIT_ORDER_COUNT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    /// <summary>
    /// 주문타입제한
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? LIMIT_ORDER_TYPE_STR { get; set; }

    /// <summary>
    /// 지역제한
    /// </summary>
    [StringLength(500)]
    [Unicode(false)]
    public string? LIMIT_DELIVERY_REGION_STR { get; set; }

    /// <summary>
    /// 가입일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? WeddingHall { get; set; }

    public bool? EcoCardYn { get; set; }
}
