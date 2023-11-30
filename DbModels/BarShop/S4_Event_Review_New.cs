using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 샘플이용후기
/// </summary>
public partial class S4_Event_Review_New
{
    [Key]
    public int ER_Idx { get; set; }

    public int ER_Company_Seq { get; set; }

    public int ER_Order_Seq { get; set; }

    public int ER_Type { get; set; }

    public int? ER_Card_Seq { get; set; }

    [StringLength(10)]
    public string? ER_Card_Code { get; set; }

    [StringLength(20)]
    public string ER_UserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ER_Regdate { get; set; }

    public int? ER_Recom_Cnt { get; set; }

    [Column(TypeName = "ntext")]
    public string? ER_Review_Title { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url { get; set; }

    [Column(TypeName = "ntext")]
    public string? ER_Review_Content { get; set; }

    public int? ER_Review_Star { get; set; }

    public int? ER_Status { get; set; }

    public int? ER_View { get; set; }

    [StringLength(20)]
    public string? ER_UserName { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url_a { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url_b { get; set; }
}
