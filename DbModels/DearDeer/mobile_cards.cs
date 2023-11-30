using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 모바일청첩장
/// </summary>
[Index("order_id", Name = "idx_order1")]
[Index("mcard_code", "deleted_at", Name = "idx_order2")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class mobile_cards
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? template_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? product_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? order_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? order_item_id { get; set; }

    [StringLength(100)]
    public string? order_no { get; set; }

    [StringLength(100)]
    public string? order_item_no { get; set; }

    [StringLength(100)]
    public string? mcard_name { get; set; }

    [StringLength(255)]
    public string? mcard_desc { get; set; }

    [StringLength(30)]
    public string? mcard_code { get; set; }

    [StringLength(100)]
    public string? mcard_label { get; set; }

    [StringLength(50)]
    public string? groom_name { get; set; }

    [StringLength(50)]
    public string? groom_name_en { get; set; }

    [StringLength(30)]
    public string? groom_rank { get; set; }

    [StringLength(30)]
    public string? groom_phone { get; set; }

    [StringLength(50)]
    public string? groom_father { get; set; }

    [StringLength(50)]
    public string? groom_mother { get; set; }

    [StringLength(50)]
    public string? bride_name { get; set; }

    [StringLength(50)]
    public string? bride_name_en { get; set; }

    [StringLength(30)]
    public string? bride_rank { get; set; }

    [StringLength(30)]
    public string? bride_phone { get; set; }

    [StringLength(50)]
    public string? bride_father { get; set; }

    [StringLength(50)]
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
    public string? wedd_time { get; set; }

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

    /// <summary>
    /// T:슬라이드배너 / N: 썸네일형/L:리스트형
    /// </summary>
    [StringLength(1)]
    public string use_gallary { get; set; } = null!;

    [StringLength(1)]
    public string use_toss { get; set; } = null!;

    [StringLength(1)]
    public string use_facebook { get; set; } = null!;

    [StringLength(1)]
    public string use_guestbook { get; set; } = null!;

    /// <summary>
    /// T:확대가능 / F:확대불가능
    /// </summary>
    [StringLength(1)]
    public string use_scale { get; set; } = null!;

    [StringLength(255)]
    public string? represent_image { get; set; }

    [StringLength(255)]
    public string? represent_image2 { get; set; }

    [StringLength(255)]
    public string? greeting_image { get; set; }

    [StringLength(255)]
    public string? greeting_image2 { get; set; }

    /// <summary>
    /// 미리보기이미지
    /// </summary>
    [StringLength(255)]
    public string? preview_image { get; set; }

    [StringLength(50)]
    public string? orderby { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? start_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? end_at { get; set; }

    [StringLength(1)]
    public string is_disabled { get; set; } = null!;

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
    /// 메인, 인사말 이미지로 표시하기. T:이미지, F:글자
    /// </summary>
    [StringLength(1)]
    public string use_show_image { get; set; } = null!;

    /// <summary>
    /// T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_map { get; set; } = null!;

    /// <summary>
    /// 오시는 길을 json으로 넣어버릴꺼야
    /// </summary>
    [Column(TypeName = "text")]
    public string? map_route { get; set; }

    /// <summary>
    /// 폰트 사이즈 em
    /// </summary>
    [Column(TypeName = "double(8,2)")]
    public double map_route_font_size { get; set; }

    /// <summary>
    /// T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_map_route { get; set; } = null!;

    /// <summary>
    /// 계좌번호입력사용. T:사용함, F:사용안함
    /// </summary>
    [StringLength(1)]    
    public string? use_account { get; set; }
    
    /// <summary>
    /// sns 공유이미지
    /// </summary>
    [StringLength(255)]
    public string? social_image { get; set; }
    /// <summary>
    /// 화환선물 사용여부 (T:사용함, F:사용안함)
    /// </summary>
    [StringLength(1)]
    public string? use_flower_gift { get; set; }
}
