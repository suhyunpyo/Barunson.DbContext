using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 포토갤러리
/// </summary>
public partial class mcard_Gallery
{
    /// <summary>
    /// 갤러리일련번호
    /// </summary>
    [Key]
    public int GalleryID { get; set; }

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
    /// 이미지경로
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string ImagePath { get; set; } = null!;

    /// <summary>
    /// 이미지순서
    /// </summary>
    public int ImageOrder { get; set; }

    /// <summary>
    /// 이미지가로
    /// </summary>
    public int ImageWidth { get; set; }

    /// <summary>
    /// 이미지세로
    /// </summary>
    public int ImageHeight { get; set; }

    /// <summary>
    /// 이미지용량
    /// </summary>
    public int ImageSize { get; set; }

    /// <summary>
    /// 등록시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime RegisterTime { get; set; }

    [ForeignKey("InvitationID")]
    [InverseProperty("mcard_Gallery")]
    public virtual mcard_Invitation Invitation { get; set; } = null!;
}
