using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_custom_order_WeddInfo_backup_order_seq")]
public partial class custom_order_WeddInfo_backup
{
    public int? id { get; set; }

    public int iid { get; set; }

    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ftype { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? fetype { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? event_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_Day { get; set; }

    [StringLength(50)]
    public string? event_weekname { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? lunar_yes_or_no { get; set; }

    [StringLength(50)]
    public string? lunar_event_Date { get; set; }

    [StringLength(20)]
    public string? event_ampm { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_minute { get; set; }

    [StringLength(200)]
    public string? wedd_name { get; set; }

    [StringLength(200)]
    public string? wedd_place { get; set; }

    [StringLength(1000)]
    public string? wedd_addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_phone { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? map_trans_method { get; set; }

    public int? wedd_idx { get; set; }

    public int? weddimg_idx { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? map_uploadfile { get; set; }

    [StringLength(4000)]
    public string? map_info { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotMapPrint { get; set; }

    [StringLength(4000)]
    public string? greeting_content { get; set; }

    [StringLength(100)]
    public string? groom_name { get; set; }

    [StringLength(100)]
    public string? bride_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? groom_initial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? bride_initial { get; set; }

    [StringLength(100)]
    public string? groom_name_eng { get; set; }

    [StringLength(100)]
    public string? bride_name_eng { get; set; }

    [StringLength(100)]
    public string? groom_Fname_eng { get; set; }

    [StringLength(100)]
    public string? bride_Fname_eng { get; set; }

    [StringLength(50)]
    public string? groom_tail { get; set; }

    [StringLength(50)]
    public string? bride_tail { get; set; }

    [StringLength(100)]
    public string? groom_father { get; set; }

    [StringLength(100)]
    public string? groom_mother { get; set; }

    [StringLength(50)]
    public string? groom_rank { get; set; }

    [StringLength(100)]
    public string? bride_father { get; set; }

    [StringLength(100)]
    public string? bride_mother { get; set; }

    [StringLength(50)]
    public string? bride_rank { get; set; }

    [StringLength(50)]
    public string? groom_fname { get; set; }

    [StringLength(50)]
    public string? bride_fname { get; set; }

    [StringLength(50)]
    public string? groom_father_fname { get; set; }

    [StringLength(50)]
    public string? groom_mother_fname { get; set; }

    [StringLength(50)]
    public string? bride_father_fname { get; set; }

    [StringLength(50)]
    public string? bride_mother_fname { get; set; }

    [StringLength(50)]
    public string? groom_father_tail { get; set; }

    [StringLength(50)]
    public string? groom_mother_tail { get; set; }

    [StringLength(50)]
    public string? bride_father_tail { get; set; }

    [StringLength(50)]
    public string? bride_mother_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isgroom_tail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isbride_tail { get; set; }

    [StringLength(50)]
    public string? groom_father_header { get; set; }

    [StringLength(50)]
    public string? groom_mother_header { get; set; }

    [StringLength(50)]
    public string? bride_father_header { get; set; }

    [StringLength(50)]
    public string? bride_mother_header { get; set; }

    [StringLength(1000)]
    public string? invite_name { get; set; }

    [StringLength(4000)]
    public string? etc_comment { get; set; }

    [StringLength(500)]
    public string? etc_file { get; set; }

    [StringLength(500)]
    public string? picture1 { get; set; }

    [StringLength(500)]
    public string? picture2 { get; set; }

    [StringLength(500)]
    public string? picture3 { get; set; }

    [StringLength(400)]
    public string? msg1 { get; set; }

    [StringLength(200)]
    public string? keyimg { get; set; }

    [StringLength(100)]
    public string? wedd_date { get; set; }

    public int? map_id { get; set; }

    public int? traffic_id { get; set; }

    [StringLength(400)]
    public string? wedd_ename { get; set; }

    [StringLength(500)]
    public string? picture4 { get; set; }

    [StringLength(500)]
    public string? picture5 { get; set; }

    [StringLength(500)]
    public string? picture6 { get; set; }

    [StringLength(500)]
    public string? picture7 { get; set; }

    [StringLength(500)]
    public string? picture8 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? groom_initial1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? bride_initial1 { get; set; }

    [StringLength(100)]
    public string? groom_name_eng1 { get; set; }

    [StringLength(100)]
    public string? bride_name_eng1 { get; set; }

    [StringLength(100)]
    public string? groom_Fname_eng1 { get; set; }

    [StringLength(100)]
    public string? bride_Fname_eng1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? groom_star { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? bride_star { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotPlacePrint { get; set; }

    [StringLength(1000)]
    public string? wedd_road_Addr { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? addr_gb { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AddrDirectInd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? groom_Illustration { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? bride_Illustration { get; set; }

    [StringLength(200)]
    public string? worship_title { get; set; }

    [StringLength(4)]
    public string? worship_header { get; set; }

    [StringLength(200)]
    public string? worship_name { get; set; }

    [StringLength(4000)]
    public string? worship_content { get; set; }

    [StringLength(200)]
    public string? hymn_title1 { get; set; }

    [StringLength(4000)]
    public string? hymn_content1 { get; set; }

    [StringLength(200)]
    public string? hymn_title2 { get; set; }

    [StringLength(4000)]
    public string? hymn_content2 { get; set; }

    [StringLength(200)]
    public string? bible_title { get; set; }

    [StringLength(4000)]
    public string? bible_content { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MiniCard_Opt { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MiniCard_Contents { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MiniCard_Contents2 { get; set; }

    [StringLength(4000)]
    public string? greeting_content2 { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Account_Number { get; set; }
}
