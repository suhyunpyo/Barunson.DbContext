using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 영역
/// </summary>
public partial class TB_Area
{
    /// <summary>
    /// 영역_ID
    /// </summary>
    [Key]
    public int Area_ID { get; set; }

    /// <summary>
    /// 영역_명
    /// </summary>
    [StringLength(100)]
    public string? Area_Name { get; set; }

    /// <summary>
    /// 청첩장_여부 (사용하지 않음)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? WeddingCard_YN { get; set; }

    /// <summary>
    /// 감사장_여부 (사용하지 않음)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? ThanksCard_YN { get; set; }

    /// <summary>
    /// 편집_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Edit_YN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Product_Category_Codes { get; set; }

    [InverseProperty("Area")]
    public virtual ICollection<TB_Invitation_Area> TB_Invitation_Area { get; } = new List<TB_Invitation_Area>();

    [InverseProperty("Area")]
    public virtual ICollection<TB_Template_Area> TB_Template_Area { get; } = new List<TB_Template_Area>();
}
