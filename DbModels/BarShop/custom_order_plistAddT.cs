using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드 추가판 기타내용
/// </summary>
public partial class custom_order_plistAddT
{
    [Key]
    public int id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ttype { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? contents { get; set; }

    public int pid { get; set; }
}
