using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 유니세프 기부금관련정보
/// </summary>
public partial class custom_order_unicef
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isjumin { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string? jumin { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isulogo_print { get; set; } = null!;
}
