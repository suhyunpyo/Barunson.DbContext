using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 초대장
/// </summary>
[Index("Order_ID", Name = "IX_TB_Invitation_Order_ID", IsUnique = true)]
public partial class TB_Invitation
{
    /// <summary>
    /// 초대장_ID
    /// </summary>
    [Key]
    public int Invitation_ID { get; set; }

    /// <summary>
    /// 주문_ID
    /// </summary>
    public int Order_ID { get; set; }

    /// <summary>
    /// 템플릿_ID
    /// </summary>
    public int Template_ID { get; set; }

    /// <summary>
    /// 사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? User_ID { get; set; }

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

    [StringLength(1)]
    [Unicode(false)]
    public string? Invitation_Display_YN { get; set; }

    [ForeignKey("Order_ID")]
    [InverseProperty("TB_Invitation")]
    public virtual TB_Order Order { get; set; } = null!;

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Account> TB_Account { get; } = new List<TB_Account>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Account_Extra> TB_Account_Extra { get; } = new List<TB_Account_Extra>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Gallery> TB_Gallery { get; } = new List<TB_Gallery>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_GuestBook> TB_GuestBook { get; } = new List<TB_GuestBook>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Invitation_Account> TB_Invitation_Account { get; } = new List<TB_Invitation_Account>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Invitation_Area> TB_Invitation_Area { get; } = new List<TB_Invitation_Area>();

    [InverseProperty("Invitation")]
    public virtual TB_Invitation_Detail? TB_Invitation_Detail { get; set; }

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Invitation_Detail_Etc> TB_Invitation_Detail_Etc { get; } = new List<TB_Invitation_Detail_Etc>();

    [InverseProperty("Invitation")]
    public virtual ICollection<TB_Invitation_Item> TB_Invitation_Item { get; } = new List<TB_Invitation_Item>();

    [ForeignKey("Template_ID")]
    [InverseProperty("TB_Invitation")]
    public virtual TB_Template Template { get; set; } = null!;
}
