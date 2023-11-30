using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 에러로그
/// </summary>
[Keyless]
public partial class Error_User
{
    public int? company_seq { get; set; }

    [StringLength(50)]
    public string? uid { get; set; }

    [StringLength(200)]
    public string? order_email { get; set; }

    [StringLength(300)]
    public string? bigo1 { get; set; }

    [StringLength(300)]
    public string? bigo2 { get; set; }

    [StringLength(300)]
    public string? bigo3 { get; set; }

    [StringLength(300)]
    public string? bigo4 { get; set; }

    [StringLength(300)]
    public string? bigo5 { get; set; }

    [StringLength(300)]
    public string? bigo6 { get; set; }

    [StringLength(300)]
    public string? bigo7 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
