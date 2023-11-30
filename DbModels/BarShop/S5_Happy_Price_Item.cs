using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 할인 카드
/// </summary>
[PrimaryKey("hpi_idx", "hpi_hp_idx")]
public partial class S5_Happy_Price_Item
{
    [Key]
    public int hpi_idx { get; set; }

    [Key]
    public int hpi_hp_idx { get; set; }

    public int hpi_Card_seq { get; set; }

    [StringLength(200)]
    public string? hpi_title { get; set; }

    public int hpi_limit_cnt { get; set; }

    public int hpi_sale_cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hpi_regdate { get; set; }

    public int hpi_status { get; set; }
}
