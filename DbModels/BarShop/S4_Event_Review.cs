using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샘플이용후기
/// </summary>
[Index("ER_Company_Seq", "ER_View", "ER_Type", Name = "IDX_S4_Event_Review_ER_Company_Seq_ER_View_ER_Type")]
public partial class S4_Event_Review
{
    [Key]
    public int ER_Idx { get; set; }

    public int ER_Company_Seq { get; set; }

    public int ER_Order_Seq { get; set; }

    public int ER_Type { get; set; }

    public int? ER_Card_Seq { get; set; }

    [StringLength(10)]
    public string? ER_Card_Code { get; set; }

    [StringLength(100)]
    public string ER_UserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ER_Regdate { get; set; }

    public int? ER_Recom_Cnt { get; set; }

    [StringLength(150)]
    public string? ER_Review_Title { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url { get; set; }

    [StringLength(500)]
    public string? ER_Review_Url2 { get; set; }

    [Column(TypeName = "ntext")]
    public string? ER_Review_Content { get; set; }

    public int? ER_Review_Star { get; set; }

    public int? ER_Review_Price { get; set; }

    public int? ER_Review_Design { get; set; }

    public int? ER_Review_Quality { get; set; }

    public int? ER_Review_Satisfaction { get; set; }

    /// <summary>
    /// 승인여
    /// </summary>
    public int? ER_Status { get; set; }

    /// <summary>
    /// 전시/비전시여부
    /// </summary>
    public int? ER_View { get; set; }

    [StringLength(20)]
    public string? ER_UserName { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url_a { get; set; }

    [StringLength(250)]
    public string? ER_Review_Url_b { get; set; }

    [StringLength(1)]
    public string? ER_isBest { get; set; }

    [StringLength(1)]
    public string? ER_isPhoto { get; set; }

    public int? ER_Gift_Code { get; set; }

    [Column(TypeName = "ntext")]
    public string? ER_Review_Reply { get; set; }

    [StringLength(500)]
    public string? ER_Review_Url3 { get; set; }

    [StringLength(20)]
    public string? inflow_route { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ER_Comm_Div { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? device_type { get; set; }

    [Column(TypeName = "text")]
    public string? ER_Comment { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ER_EMAIL { get; set; }

    public int? again_confirm { get; set; }
}
