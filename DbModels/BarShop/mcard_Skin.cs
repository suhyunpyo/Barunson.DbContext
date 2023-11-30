using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일 스킨정보
/// </summary>
public partial class mcard_Skin
{
    /// <summary>
    /// 스킨일련번호
    /// </summary>
    [Key]
    public int SkinID { get; set; }

    /// <summary>
    /// 스킨코드
    /// </summary>
    [StringLength(5)]
    public string SkinCode { get; set; } = null!;

    /// <summary>
    /// 메인이미지사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string MainImageYN { get; set; } = null!;

    /// <summary>
    /// 스킨경로
    /// </summary>
    [StringLength(300)]
    [Unicode(false)]
    public string? SkinPath { get; set; }

    /// <summary>
    /// 스킨비율가로
    /// </summary>
    [StringLength(12)]
    [Unicode(false)]
    public string? MainRatioW { get; set; }

    /// <summary>
    /// 스킨비율세로
    /// </summary>
    [StringLength(12)]
    [Unicode(false)]
    public string? MainRatioH { get; set; }

    /// <summary>
    /// 날짜언어
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? DateENKR { get; set; }

    /// <summary>
    /// 날짜구분자
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? DateSeparater { get; set; }

    /// <summary>
    /// 스킨명(영어)
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? SkinNameEN { get; set; }

    /// <summary>
    /// 스킨명(한글)
    /// </summary>
    [StringLength(30)]
    public string? SkinNameKR { get; set; }

    /// <summary>
    /// 초대장종류
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string InvitationType { get; set; } = null!;

    [InverseProperty("Skin")]
    public virtual ICollection<mcard_Invitation> mcard_Invitation { get; } = new List<mcard_Invitation>();

    [InverseProperty("Skin")]
    public virtual ICollection<mcard_TmpInvitation> mcard_TmpInvitation { get; } = new List<mcard_TmpInvitation>();
}
