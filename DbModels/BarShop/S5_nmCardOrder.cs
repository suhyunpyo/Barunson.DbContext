using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일초대장
/// </summary>
public partial class S5_nmCardOrder
{
    [Key]
    public int Order_Seq { get; set; }

    public int Company_Seq { get; set; }

    public int Mobile_Skin_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string order_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Addr { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? groom_name_kor { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? groom_name_eng { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? groom_hphone { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? bride_name_kor { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? bride_name_eng { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? bride_hphone { get; set; }

    [StringLength(4000)]
    public string? greeting_content { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? event_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_Day { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? event_weekname { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? event_ampm { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? event_hour { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? event_minute { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? lunar_yorn { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WeddingHall { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wedd_phone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? wedd_place { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WeddingAddr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? longitude { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Qrcode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? show_hash { get; set; }

    public int? worder_seq { get; set; }

    public byte? status_seq { get; set; }

    public byte? settle_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_state { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? ModDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? map_type { get; set; }
}
