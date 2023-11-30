using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 스티커
/// </summary>
[MySqlCharSet("latin1")]
[MySqlCollation("latin1_swedish_ci")]
public partial class stickers
{
    /// <summary>
    /// 스티커_ID
    /// </summary>
    [Key]
    [Column(TypeName = "int(11)")]
    public int id { get; set; }

    /// <summary>
    /// 제품_ID
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    /// <summary>
    /// 제품_코드
    /// </summary>
    [StringLength(30)]
    [MySqlCharSet("utf8")]
    [MySqlCollation("utf8_general_ci")]
    public string? code { get; set; }

    /// <summary>
    /// 기본_수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int qty { get; set; }

    [Column(TypeName = "int(11)")]
    public int default_qty { get; set; }

    /// <summary>
    /// 최대_주문_수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int max_qty { get; set; }
}
