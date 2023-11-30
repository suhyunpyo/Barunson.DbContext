using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CART
{
    [Key]
    public int CART_SEQ { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    /// <summary>
    /// S:샘플
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string ORDER_TYPE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CART_OWNER { get; set; } = null!;

    [StringLength(128)]
    [Unicode(false)]
    public string? OWNER_SESSION_ID { get; set; }

    public int CARD_NUM { get; set; }

    public int? UNIT_PRICE { get; set; }

    public int? DISCOUNT_RATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }

    public int CARD_SEQ { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CARD_OPTION { get; set; }
}
