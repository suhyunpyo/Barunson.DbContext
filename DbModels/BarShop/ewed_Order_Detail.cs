using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_Order_Detail
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string order_div { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? greeting { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? p_input_yn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? g_father { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? g_mother { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? g_position { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? g_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? b_father { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? b_mother { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? b_position { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? b_name { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? wedding_y { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedding_m { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedding_d { get; set; }

    public byte? wedding_w { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? wedding_t { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedding_h { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedding_mn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? lunar_yn { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? lunar_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? place_data_way { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? place_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? place_addr { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? place_phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? place_wedding { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? map_send_way { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_file { get; set; }

    [Column(TypeName = "text")]
    public string? map_memo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? music_use_yn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? music_file { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? photo_use_yn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? we_file { get; set; }

    [Column(TypeName = "text")]
    public string? traffic { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? we_use_yn { get; set; }

    [Column(TypeName = "text")]
    public string? we_g_ment { get; set; }

    [Column(TypeName = "text")]
    public string? we_b_ment { get; set; }

    [Column(TypeName = "text")]
    public string? we_meet { get; set; }

    [Column(TypeName = "text")]
    public string? we_plan { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? visit_use_yn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? attend_use_yn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? man_story_title { get; set; }

    [Column(TypeName = "text")]
    public string? man_story { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? woman_story_title { get; set; }

    [Column(TypeName = "text")]
    public string? woman_story { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedding_story_title { get; set; }

    [Column(TypeName = "text")]
    public string? wedding_story { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? wedd_food { get; set; }

    [Column(TypeName = "text")]
    public string? interview1 { get; set; }

    [Column(TypeName = "text")]
    public string? interview2 { get; set; }

    [Column(TypeName = "text")]
    public string? interview3 { get; set; }

    [Column(TypeName = "text")]
    public string? interview4 { get; set; }

    [Column(TypeName = "text")]
    public string? interview5 { get; set; }

    [Column(TypeName = "text")]
    public string? to_bride { get; set; }

    [Column(TypeName = "text")]
    public string? to_groom { get; set; }
}
