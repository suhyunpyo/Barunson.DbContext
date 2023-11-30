using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 장바구니
/// </summary>
[PrimaryKey("CART_OWNER_ID", "CARD_SEQ")]
public partial class S4_CART
{
    public int CART_SEQ { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string CART_OWNER_ID { get; set; } = null!;

    [Key]
    public int CARD_SEQ { get; set; }

    public int? COMPANY_SEQ { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    /// <summary>
    /// O:시판주문,S:샘플주문
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ORDER_TYPE { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string? OWNER_SESSION_ID { get; set; }

    public int CARD_NUM { get; set; }

    public int? UNIT_PRICE { get; set; }

    public int? DISCOUNT_RATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CARD_OPTION { get; set; }

    public int? Order_Seq { get; set; }

    public int? Cart_Status { get; set; }
}
