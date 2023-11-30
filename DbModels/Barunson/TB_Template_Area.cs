using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 템플릿_영역
/// </summary>
[PrimaryKey("Template_ID", "Area_ID")]
public partial class TB_Template_Area
{
    /// <summary>
    /// 템플릿_ID
    /// </summary>
    [Key]
    public int Template_ID { get; set; }

    /// <summary>
    /// 영역_ID
    /// </summary>
    [Key]
    public int Area_ID { get; set; }

    /// <summary>
    /// 사이즈_높이
    /// </summary>
    public double? Size_Height { get; set; }

    /// <summary>
    /// 사이즈_너비
    /// </summary>
    public double? Size_Width { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    public int? Sort { get; set; }

    /// <summary>
    /// 등록_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    /// <summary>
    /// 등록_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    /// <summary>
    /// 수정_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    /// <summary>
    /// 수정_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    /// <summary>
    /// 수정_IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Color { get; set; }

    [ForeignKey("Area_ID")]
    [InverseProperty("TB_Template_Area")]
    public virtual TB_Area Area { get; set; } = null!;

    [ForeignKey("Template_ID")]
    [InverseProperty("TB_Template_Area")]
    public virtual TB_Template Template { get; set; } = null!;
}
