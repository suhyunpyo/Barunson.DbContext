using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Category_Manage
{
    /// <summary>
    /// Sequence
    /// </summary>
    [Key]
    public int CM_Idx { get; set; }

    /// <summary>
    /// 사이트고유ID
    /// </summary>
    public int CM_SiteID { get; set; }

    /// <summary>
    /// 1차코드
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? CM_Code1 { get; set; }

    /// <summary>
    /// 2차코드
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? CM_Code2 { get; set; }

    /// <summary>
    /// 3차코드
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? CM_Code3 { get; set; }

    /// <summary>
    /// 통합코드
    /// </summary>
    [StringLength(8)]
    public string? CM_Code_Merge { get; set; }

    /// <summary>
    /// 카테고리명
    /// </summary>
    [StringLength(50)]
    public string? CM_Name { get; set; }

    /// <summary>
    /// 0:비전시, 1:전시
    /// </summary>
    public int CM_Status { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime CM_Regdate { get; set; }

    [StringLength(100)]
    public string? CM_Banner { get; set; }
}
