using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_order_weddinfo
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? greeting { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? greeting2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? greeting3 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? greeting4 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? greeting5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? g_name { get; set; }

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
    public string? place_data_way { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? place_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? place_addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? place_phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? place_wedding { get; set; }

    public int? wedd_idx { get; set; }

    public int? weddimg_idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_file { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? map_url { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? map_homepage { get; set; }

    [Column(TypeName = "text")]
    public string? map_memo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? logo_path { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? linkchk { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? link_title { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? link_url { get; set; }
}
