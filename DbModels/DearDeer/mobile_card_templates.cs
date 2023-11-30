using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 모바일청첩장 템플릿
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class mobile_card_templates
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? updater_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(30)]
    public string? code { get; set; }

    [StringLength(100)]
    public string? template_label { get; set; }

    [StringLength(30)]
    public string? groom_name { get; set; }

    [StringLength(30)]
    public string? groom_name_en { get; set; }

    [StringLength(30)]
    public string? groom_rank { get; set; }

    [StringLength(30)]
    public string? groom_phone { get; set; }

    [StringLength(30)]
    public string? groom_father { get; set; }

    [StringLength(30)]
    public string? groom_mother { get; set; }

    [StringLength(30)]
    public string? bride_name { get; set; }

    [StringLength(30)]
    public string? bride_name_en { get; set; }

    [StringLength(30)]
    public string? bride_rank { get; set; }

    [StringLength(30)]
    public string? bride_phone { get; set; }

    [StringLength(30)]
    public string? bride_father { get; set; }

    [StringLength(30)]
    public string? bride_mother { get; set; }

    [Column(TypeName = "text")]
    public string? greeting { get; set; }

    [StringLength(255)]
    public string? map_title { get; set; }

    [StringLength(255)]
    public string? map_address { get; set; }

    [StringLength(255)]
    public string? map_new_address { get; set; }

    [StringLength(255)]
    public string? map_lat { get; set; }

    [StringLength(255)]
    public string? map_long { get; set; }

    [StringLength(255)]
    public string? map_phone { get; set; }

    [StringLength(255)]
    public string? map_detail { get; set; }

    [StringLength(20)]
    public string? wedd_date { get; set; }

    [StringLength(10)]
    public string? wedd_hour { get; set; }

    [StringLength(10)]
    public string? wedd_minute { get; set; }

    [StringLength(7)]
    public string background_color { get; set; } = null!;

    [StringLength(7)]
    public string primary_color { get; set; } = null!;

    [StringLength(7)]
    public string secondary_color { get; set; } = null!;

    [StringLength(7)]
    public string font_color { get; set; } = null!;

    [StringLength(1)]
    public string use_gallary { get; set; } = null!;

    [StringLength(255)]
    public string? represent_image { get; set; }

    [StringLength(255)]
    public string? represent_image2 { get; set; }

    [StringLength(255)]
    public string? greeting_image { get; set; }

    [StringLength(255)]
    public string? greeting_image2 { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    /// <summary>
    /// 영상사용. T:사용함, F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_movie { get; set; } = null!;

    /// <summary>
    /// 영상링크 유알엘
    /// </summary>
    [StringLength(100)]
    public string? movie_link { get; set; }

    /// <summary>
    /// 부모님 전화 사용. T:사용함, F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_telephone { get; set; } = null!;

    /// <summary>
    /// 신랑 아버지 전화번호
    /// </summary>
    [StringLength(20)]
    public string? groom_father_phone { get; set; }

    /// <summary>
    /// 신랑 어머니 전화번호
    /// </summary>
    [StringLength(20)]
    public string? groom_mother_phone { get; set; }

    /// <summary>
    /// 신부 아버지 전화번호
    /// </summary>
    [StringLength(20)]
    public string? bride_father_phone { get; set; }

    /// <summary>
    /// 신부 어머니 전화번호
    /// </summary>
    [StringLength(20)]
    public string? bride_mother_phone { get; set; }

    /// <summary>
    /// 계좌번호입력사용 T:사용함, F:사용안함
    /// </summary>
    [StringLength(1)]
    public string? use_account { get; set; }
}
