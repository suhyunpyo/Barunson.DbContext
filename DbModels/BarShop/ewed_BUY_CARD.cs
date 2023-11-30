using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_BUY_CARD
{
    [Key]
    public int buy_card_SEQ { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string buy_card_UID { get; set; } = null!;

    public byte buy_STATUS { get; set; }

    public int CARD_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime buy_card_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime buy_card_MAXDATE { get; set; }

    public int buy_card_price { get; set; }

    [InverseProperty("buy_card_SEQNavigation")]
    public virtual ewed_BUY_CARD_CONTENT? ewed_BUY_CARD_CONTENT { get; set; }

    [InverseProperty("buy_card_SEQNavigation")]
    public virtual ewed_BUY_SETTLE_INFO? ewed_BUY_SETTLE_INFO { get; set; }
}
