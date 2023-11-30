using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// CUSTOM_ETC_ORDER_WeddInfo
/// </summary>
public partial class CUSTOM_ETC_ORDER_WeddInfo
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? groom_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? bride_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_day { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_minuite { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedd_ampm { get; set; }

    public byte? wedd_week { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_place { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? photo3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? tmp { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? etc_comment { get; set; }
}
