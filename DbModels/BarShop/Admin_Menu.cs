using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드전용 관리자 메뉴
/// </summary>
public partial class Admin_Menu
{
    [Key]
    public int AM_Idx { get; set; }

    public int? AM_SiteID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AM_Code1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? AM_Code2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? AM_Code3 { get; set; }

    [StringLength(8)]
    public string? AM_Code_Merge { get; set; }

    [StringLength(50)]
    public string? AM_Name { get; set; }

    [StringLength(200)]
    public string? AM_URL { get; set; }

    public int AM_Status { get; set; }

    public int? AM_Sort { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime AM_Regdate { get; set; }

    [StringLength(100)]
    public string? AM_Image1 { get; set; }

    [StringLength(100)]
    public string? AM_Image2 { get; set; }

    [StringLength(100)]
    public string? AM_Image3 { get; set; }
}
