using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class homuro_board_item
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    [StringLength(20)]
    public string? user_name { get; set; }

    /// <summary>
    /// 상품코드
    /// </summary>
    [StringLength(255)]
    public string? product_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    /// <summary>
    /// 게시판 index값
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? homuro_id { get; set; }
}
