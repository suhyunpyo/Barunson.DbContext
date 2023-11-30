using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장 기본정보(문의하기)
/// </summary>
public partial class mcard_InvitationParty
{
    /// <summary>
    /// 기타초대장일련번호
    /// </summary>
    [Key]
    public int PartyID { get; set; }

    /// <summary>
    /// 초대장일련번호
    /// </summary>
    public int InvitationID { get; set; }

    /// <summary>
    /// 주최사(자)명
    /// </summary>
    [StringLength(30)]
    public string GroupName { get; set; } = null!;

    /// <summary>
    /// 주최사(자)담당연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string GroupMobile { get; set; } = null!;

    /// <summary>
    /// 주요정보타이틀명
    /// </summary>
    [StringLength(50)]
    public string? GuideName { get; set; }

    /// <summary>
    /// 주요정보내용
    /// </summary>
    [StringLength(1000)]
    public string? GuideNote { get; set; }

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_InvitationParty")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
