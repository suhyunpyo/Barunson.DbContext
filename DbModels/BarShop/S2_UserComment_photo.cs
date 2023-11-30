using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이용후기 사진업로드 관련
/// </summary>
[Index("seq", Name = "NCI_S2_UserComment_photo_seq")]
public partial class S2_UserComment_photo
{
    [Key]
    public int S2_USERCOMMENT_PHOTO_SEQ { get; set; }

    public int seq { get; set; }

    [StringLength(100)]
    public string img_name { get; set; } = null!;

    [StringLength(100)]
    public string upimg_name { get; set; } = null!;
}
