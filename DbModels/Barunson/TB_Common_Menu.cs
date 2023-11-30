using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 공통_메뉴
/// </summary>
public partial class TB_Common_Menu
{
    /// <summary>
    /// 메뉴_ID
    /// </summary>
    [Key]
    public int Menu_ID { get; set; }

    /// <summary>
    /// 상위_메뉴_아이디
    /// </summary>
    public int? Parent_Menu_ID { get; set; }

    /// <summary>
    /// 메뉴_명
    /// </summary>
    [StringLength(100)]
    public string? Menu_Name { get; set; }

    /// <summary>
    /// 메뉴_구분_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Menu_Type_Code { get; set; }

    /// <summary>
    /// 메뉴_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Menu_URL { get; set; }

    /// <summary>
    /// 메뉴_단계
    /// </summary>
    public int? Menu_Step { get; set; }

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

    [StringLength(1000)]
    [Unicode(false)]
    public string? Image_URL { get; set; }

    [InverseProperty("Parent_Menu")]
    public virtual ICollection<TB_Common_Menu> InverseParent_Menu { get; } = new List<TB_Common_Menu>();

    [ForeignKey("Parent_Menu_ID")]
    [InverseProperty("InverseParent_Menu")]
    public virtual TB_Common_Menu? Parent_Menu { get; set; }
}
