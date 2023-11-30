using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Order_Seq", "card_erp_code")]
public partial class CUSTOM_ETC_ORDER_GIFT_ITEM
{
    [Key]
    public int Order_Seq { get; set; }

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string card_erp_code { get; set; } = null!;

    public int card_seq { get; set; }

    public int order_count { get; set; }

    public int card_sale_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Use_Yn { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Reg_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Mod_Date { get; set; }
}
