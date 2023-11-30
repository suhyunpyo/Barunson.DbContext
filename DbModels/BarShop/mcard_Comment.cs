using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 방명록
/// </summary>
public partial class mcard_Comment
{
    /// <summary>
    /// 방명록일련번호
    /// </summary>
    [Key]
    public int CommentID { get; set; }

    /// <summary>
    /// 초대장일련번호
    /// </summary>
    public int InvitationID { get; set; }

    /// <summary>
    /// 초대장코드
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    /// <summary>
    /// 방문객명
    /// </summary>
    [StringLength(30)]
    public string GuestName { get; set; } = null!;

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    /// <summary>
    /// 내용
    /// </summary>
    [StringLength(300)]
    public string Commentary { get; set; } = null!;

    /// <summary>
    /// 등록시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime RegisterTime { get; set; }

    /// <summary>
    /// 등록지IP
    /// </summary>
    [StringLength(15)]
    [Unicode(false)]
    public string RegisterIP { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string View_YN { get; set; } = null!;

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_Comment")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
