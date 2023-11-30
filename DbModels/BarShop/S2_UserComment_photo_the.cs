using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// (더카드)이용후기 사진업로드 관련
/// </summary>
[Keyless]
public partial class S2_UserComment_photo_the
{
    public int seq { get; set; }

    /// <summary>
    /// 이미지원본파일명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string img_name { get; set; } = null!;

    /// <summary>
    /// 이미지업로드파일명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string upimg_name { get; set; } = null!;
}
