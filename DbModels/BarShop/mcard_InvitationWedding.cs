using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장 신부신랑정보
/// </summary>
public partial class mcard_InvitationWedding
{
    /// <summary>
    /// 청첩장일련번호
    /// </summary>
    [Key]
    public int WeddingID { get; set; }

    /// <summary>
    /// 초대장일련번호
    /// </summary>
    public int InvitationID { get; set; }

    /// <summary>
    /// 신랑이름
    /// </summary>
    [StringLength(30)]
    public string GroomName { get; set; } = null!;

    /// <summary>
    /// 신랑연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string GroomMobile { get; set; } = null!;

    /// <summary>
    /// 신부이름
    /// </summary>
    [StringLength(30)]
    public string BrideName { get; set; } = null!;

    /// <summary>
    /// 신부연락처
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string BrideMobile { get; set; } = null!;

    /// <summary>
    /// 신랑측혼주관계1
    /// </summary>
    [StringLength(20)]
    public string? GroomHostRel1 { get; set; }

    /// <summary>
    /// 신랑측혼주이름1
    /// </summary>
    [StringLength(30)]
    public string? GroomHostName1 { get; set; }

    /// <summary>
    /// 신랑측혼주연락처1
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? GroomHostMobile1 { get; set; }

    /// <summary>
    /// 신랑측혼주관계2
    /// </summary>
    [StringLength(20)]
    public string? GroomHostRel2 { get; set; }

    /// <summary>
    /// 신랑측혼주이름2
    /// </summary>
    [StringLength(30)]
    public string? GroomHostName2 { get; set; }

    /// <summary>
    /// 신랑측혼주연락처2
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? GroomHostMobile2 { get; set; }

    /// <summary>
    /// 신부측혼주관계1
    /// </summary>
    [StringLength(20)]
    public string? BrideHostRel1 { get; set; }

    /// <summary>
    /// 신부측혼주이름1
    /// </summary>
    [StringLength(30)]
    public string? BrideHostName1 { get; set; }

    /// <summary>
    /// 신부측혼주연락처1
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? BrideHostMobile1 { get; set; }

    /// <summary>
    /// 신부측혼주관계2
    /// </summary>
    [StringLength(20)]
    public string? BrideHostRel2 { get; set; }

    /// <summary>
    /// 신부측혼주이름2
    /// </summary>
    [StringLength(60)]
    [Unicode(false)]
    public string? BrideHostName2 { get; set; }

    /// <summary>
    /// 신부측혼주연락처2
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? BrideHostMobile2 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? GroomAccountBank { get; set; }

    [StringLength(100)]
    public string? GroomAccountNumber { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BrideAccountBank { get; set; }

    [StringLength(100)]
    public string? BrideAccountNumber { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GroomAccountYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BrideAccountYN { get; set; }

    [StringLength(30)]
    public string? GroomAccountName { get; set; }

    [StringLength(50)]
    public string? GroomAccountRelation { get; set; }

    [StringLength(30)]
    public string? BrideAccountName { get; set; }

    [StringLength(50)]
    public string? BrideAccountRelation { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? GroomAccountBank2 { get; set; }

    [StringLength(100)]
    public string? GroomAccountNumber2 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? BrideAccountBank2 { get; set; }

    [StringLength(100)]
    public string? BrideAccountNumber2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GroomAccountYN2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BrideAccountYN2 { get; set; }

    [StringLength(30)]
    public string? GroomAccountName2 { get; set; }

    [StringLength(50)]
    public string? GroomAccountRelation2 { get; set; }

    [StringLength(30)]
    public string? BrideAccountName2 { get; set; }

    [StringLength(50)]
    public string? BrideAccountRelation2 { get; set; }

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_InvitationWedding")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
