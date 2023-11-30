using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 웨딩홀 소개
/// </summary>
public partial class weddinghall_information
{
    [Key]
    public int wedd_idx { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? wedd_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_phone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? wedd_addr { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? subway_str { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? bus_str { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? mycar_str { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? etc_str { get; set; }
}
