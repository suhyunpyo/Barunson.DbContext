using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 돐초대장
/// </summary>
public partial class mcard_InvitationBaby
{
    /// <summary>
    /// 돌초대장일련번호
    /// </summary>
    [Key]
    public int BabyID { get; set; }

    /// <summary>
    /// 초대장일련번호
    /// </summary>
    public int InvitationID { get; set; }

    /// <summary>
    /// 아이이름
    /// </summary>
    [StringLength(30)]
    public string BabyName { get; set; } = null!;

    /// <summary>
    /// 아이생일
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string BabyBirth { get; set; } = null!;

    /// <summary>
    /// 아빠이름
    /// </summary>
    [StringLength(30)]
    public string? DadName { get; set; }

    /// <summary>
    /// 아빠연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? DadMobile { get; set; }

    /// <summary>
    /// 엄마이름
    /// </summary>
    [StringLength(30)]
    public string? MomName { get; set; }

    /// <summary>
    /// 엄마연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? MomMobile { get; set; }

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_InvitationBaby")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
