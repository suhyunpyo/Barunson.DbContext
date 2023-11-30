using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 분류
/// </summary>
public partial class TB_Category
{
    /// <summary>
    /// 분류_ID
    /// </summary>
    [Key]
    public int Category_ID { get; set; }

    /// <summary>
    /// 상위_분류_ID
    /// </summary>
    public int? Parent_Category_ID { get; set; }

    /// <summary>
    /// 분류_명
    /// </summary>
    [StringLength(100)]
    public string? Category_Name { get; set; }

    /// <summary>
    /// 분류_구분_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Category_Type_Code { get; set; }

    /// <summary>
    /// 분류_명_구분_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Category_Name_Type_Code { get; set; }

    /// <summary>
    /// 분류_명_PC
    /// </summary>
    [StringLength(100)]
    public string? Category_Name_PC { get; set; }

    /// <summary>
    /// 분류_명_PC_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Category_Name_PC_URL { get; set; }

    /// <summary>
    /// 분류_명_모바일
    /// </summary>
    [StringLength(100)]
    public string? Category_Name_Mobile { get; set; }

    /// <summary>
    /// 분류_명_모바일_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Category_Name_Mobile_URL { get; set; }

    /// <summary>
    /// 분류_단계
    /// </summary>
    public int? Category_Step { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    public int? Sort { get; set; }

    /// <summary>
    /// 진열_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Display_YN { get; set; }

    /// <summary>
    /// 아이콘_ID
    /// </summary>
    public int? Icon_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Regist_IP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Update_User_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Update_DateTime { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Update_IP { get; set; }
}
