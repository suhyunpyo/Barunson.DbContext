using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// (더카드)포토카드 업로드 설명	
/// </summary>
public partial class S2_CardOption_UsrImg
{
    [Key]
    public int uimg_seq { get; set; }

    [StringLength(30)]
    public string uimg_card_code { get; set; } = null!;

    /// <summary>
    /// 사진갯수
    /// </summary>
    public int? uimg_number { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(100)]
    public string? uimg_title { get; set; }

    /// <summary>
    /// 사진위치
    /// </summary>
    [StringLength(100)]
    public string? uimg_subtitle { get; set; }

    /// <summary>
    /// 청첩장펼친이미지명
    /// </summary>
    [StringLength(200)]
    public string? uimg_info_img { get; set; }

    /// <summary>
    /// 업로드사진 설명
    /// </summary>
    [StringLength(100)]
    public string? uimg_info_text { get; set; }

    public int uimg_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime uimg_regdate { get; set; }

    public int? uimg_wh { get; set; }
}
