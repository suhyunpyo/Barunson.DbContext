using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샘플후기 사진업로드 관련
/// </summary>
[Index("seq", Name = "NCI_S4_Event_Review_photo_seq")]
public partial class S4_Event_Review_photo
{
    [Key]
    public int S4_Event_Review_PHOTO_SEQ { get; set; }

    public int seq { get; set; }

    [StringLength(100)]
    public string img_name { get; set; } = null!;

    [StringLength(100)]
    public string upimg_name { get; set; } = null!;
}
