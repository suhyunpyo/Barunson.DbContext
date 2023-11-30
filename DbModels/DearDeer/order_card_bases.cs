using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class order_card_bases
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    [StringLength(50)]
    public string order_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte cont_cnt { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte env_cnt { get; set; }
}
