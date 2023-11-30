using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S5_Event_Item
{
    public int CE_Idx { get; set; }

    public int? CE_Event_NUM { get; set; }

    public int? CE_Item_NUM { get; set; }

    [StringLength(50)]
    public string? CE_Item_NM { get; set; }

    public int? CE_Item_CNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CE_Regdate { get; set; }

    public int CE_Status { get; set; }

    [StringLength(50)]
    public string? CE_IMG { get; set; }
}
