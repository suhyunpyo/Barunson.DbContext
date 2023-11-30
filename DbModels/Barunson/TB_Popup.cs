using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 팝업
/// </summary>
public partial class TB_Popup
{
    /// <summary>
    /// 팝업_ID
    /// </summary>
    [Key]
    public int Popup_ID { get; set; }

    /// <summary>
    /// 팝업_제목
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string Popup_Title { get; set; } = null!;

    /// <summary>
    /// 팝업_PC_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Popup_PC_YN { get; set; }

    /// <summary>
    /// 팝업_모바일_여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Popup_Mobile_YN { get; set; }

    /// <summary>
    /// 팝업_위치_TOP
    /// </summary>
    public int Popup_Location_Top { get; set; }

    /// <summary>
    /// 팝업_위치_LEFT
    /// </summary>
    public int Popup_Location_Left { get; set; }

    /// <summary>
    /// 팝업_높이
    /// </summary>
    public int Popup_Height { get; set; }

    /// <summary>
    /// 팝업_너비
    /// </summary>
    public int Popup_Width { get; set; }

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

    [InverseProperty("Popup")]
    public virtual ICollection<TB_Popup_Item> TB_Popup_Item { get; } = new List<TB_Popup_Item>();
}
