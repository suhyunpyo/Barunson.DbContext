﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 템플릿_아이템
/// </summary>
public partial class TB_Template_Item
{
    /// <summary>
    /// 아이템_ID
    /// </summary>
    [Key]
    public int Item_ID { get; set; }

    /// <summary>
    /// 템플릿_ID
    /// </summary>
    public int? Template_ID { get; set; }

    /// <summary>
    /// 리소스_ID
    /// </summary>
    public int Resource_ID { get; set; }

    /// <summary>
    /// 영역_ID
    /// </summary>
    public int? Area_ID { get; set; }

    /// <summary>
    /// 텍스트
    /// 이미지
    /// 
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Item_Type_Code { get; set; }

    /// <summary>
    /// 위치_TOP
    /// </summary>
    public double? Location_Top { get; set; }

    /// <summary>
    /// 위치_LEFT
    /// </summary>
    public double? Location_Left { get; set; }

    /// <summary>
    /// 사이즈_높이
    /// </summary>
    public double? Size_Height { get; set; }

    /// <summary>
    /// 사이즈_너비
    /// </summary>
    public double? Size_Width { get; set; }

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

    [ForeignKey("Resource_ID")]
    [InverseProperty("TB_Template_Item")]
    public virtual TB_Item_Resource Resource { get; set; } = null!;

    [ForeignKey("Template_ID")]
    [InverseProperty("TB_Template_Item")]
    public virtual TB_Template? Template { get; set; }
}
