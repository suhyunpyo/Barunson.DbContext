using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 설문지 내용
/// </summary>
public partial class S4_Poll_item
{
    [Key]
    public int seq { get; set; }

    public int poll_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string item_title { get; set; } = null!;

    public int item_count { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? item_etc_div { get; set; }

    public int? sort_num { get; set; }
}
