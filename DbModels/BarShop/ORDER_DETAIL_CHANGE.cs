using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("ORDER_SEQ", "CARD_SEQ")]
public partial class ORDER_DETAIL_CHANGE
{
    [Key]
    public int ORDER_SEQ { get; set; }

    [Key]
    public int CARD_SEQ { get; set; }

    public int PRE_CARD_SEQ { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CHANGE_NOTE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CHANGE_DATE { get; set; } = null!;
}
