using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 배너
/// </summary>
public partial class TB_Banner
{
    /// <summary>
    /// 배너_ID
    /// </summary>
    [Key]
    public int Banner_ID { get; set; }

    /// <summary>
    /// 배너_분류_ID
    /// </summary>
    public int Banner_Category_ID { get; set; }

    /// <summary>
    /// 배너_PC_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Banner_PC_YN { get; set; }

    /// <summary>
    /// 배너_모바일_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Banner_Mobile_YN { get; set; }

    /// <summary>
    /// 배너_명
    /// </summary>
    [StringLength(100)]
    public string Banner_Name { get; set; } = null!;

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

    [ForeignKey("Banner_Category_ID")]
    [InverseProperty("TB_Banner")]
    public virtual TB_Banner_Category Banner_Category { get; set; } = null!;

    [InverseProperty("Banner")]
    public virtual ICollection<TB_Banner_Item> TB_Banner_Item { get; } = new List<TB_Banner_Item>();
}
