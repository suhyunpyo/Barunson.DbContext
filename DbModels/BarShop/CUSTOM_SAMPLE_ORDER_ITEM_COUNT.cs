using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CARD_SEQ", "REG_DATE")]
public partial class CUSTOM_SAMPLE_ORDER_ITEM_COUNT
{
    [Key]
    public int CARD_SEQ { get; set; }

    [Key]
    [Column(TypeName = "smalldatetime")]
    public DateTime REG_DATE { get; set; }

    public int CNT { get; set; }
}
