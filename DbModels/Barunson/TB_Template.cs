using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 템플릿
/// </summary>
public partial class TB_Template
{
    /// <summary>
    /// 템플릿_ID
    /// </summary>
    [Key]
    public int Template_ID { get; set; }

    /// <summary>
    /// 템플릿_명
    /// </summary>
    [StringLength(100)]
    public string? Template_Name { get; set; }

    /// <summary>
    /// 미리보기_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Preview_URL { get; set; }

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

    /// <summary>
    /// 포토_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Photo_YN { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Background_Color { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Attached_File1_URL { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Attached_File2_URL { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<TB_Invitation> TB_Invitation { get; } = new List<TB_Invitation>();

    [InverseProperty("Template")]
    public virtual ICollection<TB_Product> TB_Product { get; } = new List<TB_Product>();

    [InverseProperty("Template")]
    public virtual ICollection<TB_Template_Area> TB_Template_Area { get; } = new List<TB_Template_Area>();

    [InverseProperty("Template")]
    public virtual TB_Template_Detail? TB_Template_Detail { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<TB_Template_Item> TB_Template_Item { get; } = new List<TB_Template_Item>();
}
