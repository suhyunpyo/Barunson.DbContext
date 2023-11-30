using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CARD_ERP_STOCK_DEARDEER
{
    [Key]
    public int S2_CARD_ERP_STOCK_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_CODE_ERP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_TYPE_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BRAND_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BRAND_NAME_OLD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ORIGIN_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRODUCTION_STATUS_NAME { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? CLOSING_COST { get; set; }

    public int? CONSUMER_PRICE { get; set; }

    public int? CARD_SET_PRICE { get; set; }

    public int? INVENTORY_CURRENT_QTY { get; set; }

    public int? INVENTORY_REQUEST_QTY { get; set; }

    public int? INVENTORY_AVAILABLE_QTY { get; set; }

    public int? INVENTORY_NOT_MAKE_QTY { get; set; }

    public int? INVENTORY_CHINA_QTY { get; set; }

    public int? INVENTORY_MOVING_QTY { get; set; }

    public int? TOTAL_SALE_PRICE_30_DAY { get; set; }

    public int? TOTAL_SALE_PRICE_90_DAY { get; set; }

    public int? TOTAL_SALE_PRICE_180_DAY { get; set; }

    public int? TOTAL_SALE_PRICE_365_DAY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ERP_FIRST_REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RELEASE_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MOD_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
