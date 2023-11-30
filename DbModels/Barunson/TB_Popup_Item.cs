using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 팝업_아이템
/// </summary>
public partial class TB_Popup_Item
{
    /// <summary>
    /// 팝업_아이템_ID
    /// </summary>
    [Key]
    public int Popup_Item_ID { get; set; }

    /// <summary>
    /// 팝업_ID
    /// </summary>
    public int Popup_ID { get; set; }

    /// <summary>
    /// PC
    /// 모바일
    /// 
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Popup_Type_Code { get; set; } = null!;

    /// <summary>
    /// 이미지_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Image_URL { get; set; }

    /// <summary>
    /// 링크_URL
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Link_URL { get; set; }

    /// <summary>
    /// 날짜지정
    /// 무제
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Period_Type_Code { get; set; }

    /// <summary>
    /// 시작_날짜
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? Start_Date { get; set; }

    /// <summary>
    /// 시작_시간
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? Start_Time { get; set; }

    /// <summary>
    /// 종료_날짜
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? End_Date { get; set; }

    /// <summary>
    /// 종료_시간
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? End_Time { get; set; }

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

    [ForeignKey("Popup_ID")]
    [InverseProperty("TB_Popup_Item")]
    public virtual TB_Popup Popup { get; set; } = null!;
}
