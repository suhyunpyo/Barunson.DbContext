using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문 카드 입력정보
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_item_id", Name = "order_item_id")]
[Index("order_item_no", Name = "order_item_no")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_card_contents
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    [StringLength(50)]
    public string order_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    [StringLength(50)]
    public string order_item_no { get; set; } = null!;

    [Column(TypeName = "int(10) unsigned")]
    public uint content_idx { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint item_cnt { get; set; }

    [StringLength(20)]
    public string? ftype { get; set; }

    [StringLength(1000)]
    public string? ftype_str { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_inherit_greeting { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_inherit_person { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_inherit_place { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_inherit_addition { get; set; }

    [StringLength(50)]
    public string? groom_father_header { get; set; }

    [StringLength(50)]
    public string? groom_mother_header { get; set; }

    [StringLength(50)]
    public string? groom_father_fname { get; set; }

    [StringLength(50)]
    public string? groom_mother_fname { get; set; }

    [StringLength(50)]
    public string? groom_father { get; set; }

    [StringLength(50)]
    public string? groom_mother { get; set; }

    [StringLength(50)]
    public string? groom_father_tail { get; set; }

    [StringLength(50)]
    public string? groom_mother_tail { get; set; }

    [StringLength(50)]
    public string? groom_rank { get; set; }

    [StringLength(50)]
    public string? groom_fname { get; set; }

    [StringLength(50)]
    public string? groom_name { get; set; }

    [StringLength(50)]
    public string? groom_name_eng { get; set; }

    [StringLength(50)]
    public string? groom_fname_eng { get; set; }

    [StringLength(50)]
    public string? groom_tail { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte isgroom_tail { get; set; }

    [StringLength(50)]
    public string? bride_father_header { get; set; }

    [StringLength(50)]
    public string? bride_mother_header { get; set; }

    [StringLength(50)]
    public string? bride_father_fname { get; set; }

    [StringLength(50)]
    public string? bride_mother_fname { get; set; }

    [StringLength(50)]
    public string? bride_father { get; set; }

    [StringLength(50)]
    public string? bride_mother { get; set; }

    [StringLength(50)]
    public string? bride_father_tail { get; set; }

    [StringLength(255)]
    public string? bride_mother_tail { get; set; }

    [StringLength(50)]
    public string? bride_rank { get; set; }

    [StringLength(50)]
    public string? bride_fname { get; set; }

    [StringLength(50)]
    public string? bride_name { get; set; }

    [StringLength(50)]
    public string? bride_name_eng { get; set; }

    [StringLength(50)]
    public string? bride_fname_eng { get; set; }

    [StringLength(50)]
    public string? bride_tail { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte isbride_tail { get; set; }

    [StringLength(255)]
    public string? lunar_event_date { get; set; }

    [StringLength(255)]
    public string? lunar_yes_or_no { get; set; }

    [StringLength(255)]
    public string? event_weekname { get; set; }

    [Column(TypeName = "int(11)")]
    public int? event_year { get; set; }

    [Column(TypeName = "int(11)")]
    public int? event_month { get; set; }

    [Column(TypeName = "int(11)")]
    public int? event_day { get; set; }

    [StringLength(50)]
    public string? event_date { get; set; }

    [StringLength(10)]
    public string? event_hour_str { get; set; }

    [StringLength(2)]
    public string? event_minute { get; set; }

    [Column(TypeName = "int(11)")]
    public int? wedd_idx { get; set; }

    [Column(TypeName = "int(11)")]
    public int? weddimg_idx { get; set; }

    [Column(TypeName = "int(11)")]
    public int? map_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? traffic_id { get; set; }

    [StringLength(255)]
    public string? map_trans_method { get; set; }

    [StringLength(255)]
    public string? map_info { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? is_not_map_print { get; set; }

    [StringLength(255)]
    public string? addr_gb { get; set; }

    [StringLength(150)]
    public string? wedd_road_addr { get; set; }

    [StringLength(150)]
    public string? wedd_addr { get; set; }

    [StringLength(100)]
    public string? wedd_phone { get; set; }

    [StringLength(50)]
    public string? wedd_name { get; set; }

    [StringLength(50)]
    public string? wedd_place { get; set; }

    [Column(TypeName = "int(11)")]
    public int? wedd_map_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? wedd_map_item_id { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? is_not_place_print { get; set; }

    [StringLength(255)]
    public string? picture { get; set; }

    [StringLength(255)]
    public string? picture1 { get; set; }

    [StringLength(255)]
    public string? picture2 { get; set; }

    [StringLength(255)]
    public string? etc_comment1 { get; set; }

    [StringLength(255)]
    public string? etc_comment2 { get; set; }

    [Column(TypeName = "text")]
    public string? etc_comment3 { get; set; }

    [Column(TypeName = "text")]
    public string? wedd_map_road { get; set; }

    [StringLength(255)]
    public string? etc_file { get; set; }
}
