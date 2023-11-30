using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_mCardOrder
{
    [Key]
    public int Order_Seq { get; set; }

    public int? Company_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Uid { get; set; }

    [StringLength(50)]
    public string? order_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(50)]
    public string? GroomName { get; set; }

    [StringLength(50)]
    public string? BrideName { get; set; }

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

    [StringLength(100)]
    public string? WeddingHall { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WeddingAddr { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsOpen { get; set; }

    public byte? status_seq { get; set; }

    public byte? settle_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    public int? settle_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? settle_cancel_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? pg_resultinfo2 { get; set; }

    public double? pg_fee { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_state { get; set; }

    public int? worder_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? longitude { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Qrcode { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? addr { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? poi_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? poi_x { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? poi_y { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? groom_pf_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? bride_pf_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? groom_pm_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? bride_pm_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? poi_weddinghall { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? poi_weddingaddr { get; set; }
}
