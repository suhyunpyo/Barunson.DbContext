using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DEARDEER_SAMPLE_ORDER_ITEM
{
    [Key]
    public int DEARDEER_SAMPLE_ORDER_ITEM_SEQ { get; set; }

    public int DEARDEER_SAMPLE_ORDER_MST_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SAMPLE_ORDER_ITEM_NO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ITEM_CODE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ITEM_IMAGE_URL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
