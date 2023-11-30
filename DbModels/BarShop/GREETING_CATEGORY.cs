using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 인사말 카테고리
/// </summary>
public partial class GREETING_CATEGORY
{
    /// <summary>
    /// 카테고리 키
    /// </summary>
    [Key]
    public int GREETING_CATEGORY_SEQ { get; set; }

    /// <summary>
    /// 카테고리명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string GREETING_CATEGORY_NAME { get; set; } = null!;

    /// <summary>
    /// 상위 카테고리
    /// </summary>
    public int CATEGORY_UPPER_CODE { get; set; }

    /// <summary>
    /// 카테고리 설명
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string? CATEGORY_DESCRIPTION { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REGIST_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LAST_UPDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CATEGORY_USED { get; set; } = null!;

    public byte? DEPTH { get; set; }

    public short? display_seq { get; set; }

    [InverseProperty("GREETING_CATEGORY_SEQNavigation")]
    public virtual ICollection<GREETING> GREETING { get; } = new List<GREETING>();
}
