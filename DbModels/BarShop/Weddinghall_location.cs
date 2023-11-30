using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 웨딩홀 위치
/// </summary>
public partial class Weddinghall_location
{
    [Key]
    public short loc_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? loc_name { get; set; }

    public short? seq { get; set; }
}
