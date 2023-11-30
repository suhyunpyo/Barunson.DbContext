using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class RECENT_VIEW_CARD_ITEM
{
    [Key]
    public int RECENT_VIEW_CARD_ITEM_SEQ { get; set; }

    public int RECENT_VIEW_CARD_MST_SEQ { get; set; }

    public int CARD_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
